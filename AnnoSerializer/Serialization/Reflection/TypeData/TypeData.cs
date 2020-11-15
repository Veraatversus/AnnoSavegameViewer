namespace AnnoSerializer.Serialization.Reflection.TypeData {
  using AnnoSerializer.Serialization.Core;
  using System;
  using System.Collections.Concurrent;
  using System.Collections.Generic;
  using System.Reflection;

  /// <summary>
  /// Represents reflected type configuration required for reading and writing it as binary data.
  /// </summary>
  internal sealed class TypeData {

		#region Internal Properties

		/// <summary> Gets the <see cref="Type"/> to which informations are stored. </summary>
		internal Type Type { get; }

		/// <summary> Gets a parameterless <see cref="ConstructorInfo"/> to instantiate the class. </summary>
		internal ConstructorInfo Constructor { get; }

		/// <summary>
		/// Gets the dictionary of <see cref="MemberData"/> for members having the <see
		/// cref="BinaryContentTypes.Node"/> and with the <see cref="BinaryMemberAttribute.Order"/>
		/// property set.
		/// </summary>
		internal SortedDictionary<int, MemberData> OrderedNodes { get; }

		/// <summary>
		/// Gets the list of <see cref="MemberData"/> for members having the <see
		/// cref="BinaryContentTypes.Node"/> and missing the <see cref="BinaryContentAttribute.Order"/> property.
		/// </summary>
		internal SortedList<string, MemberData> UnorderedNodes { get; }

		/// <summary>
		/// Gets the dictionary of <see cref="MemberData"/> for members having the <see
		/// cref="BinaryContentTypes.Attribute"/> and with the <see cref="BinaryMemberAttribute.Order"/>
		/// property set.
		/// </summary>
		internal SortedDictionary<int, MemberData> OrderedAttributes { get; }

		/// <summary>
		/// Gets the list of <see cref="MemberData"/> for members having the <see
		/// cref="BinaryContentTypes.Attribute"/> and missing the <see
		/// cref="BinaryContentAttribute.Order"/> property.
		/// </summary>
		internal SortedList<string, MemberData> UnorderedAttributes { get; }

		#endregion Internal Properties

		#region Internal Methods

		/// <summary>
		/// Gets the <see cref="TypeData"/> instance for the given <paramref name="type"/> and caches
		/// the information on it if necessary.
		/// </summary>
		/// <param name="type"> The <see cref="Type"/> to query information about. </param>
		/// <returns> The <see cref="TypeData"/> instance holding information about the type. </returns>
		internal static TypeData GetTypeData(Type type) {
			if (!_cache.TryGetValue(type, out var typeData)) {
				typeData = new TypeData(type);
        _ = _cache.TryAdd(type, typeData);
			}
			return typeData;
		}

		/// <summary> Invokes the parameterless constructor on the object. </summary>
		/// <returns> A new instance of the object. </returns>
		internal object GetInstance() {
			// Invoke the automatic default constructor for structs.
			if (Type.IsValueType) {
				return Activator.CreateInstance(Type);
			}

      // Invoke an explicit parameterless constructor for classes.
      return Constructor == null
        ?        throw new MissingMethodException($"No parameterless constructor found for {Type}.")
        : Constructor.Invoke(null);
    }

    #endregion Internal Methods

    #region Private Constructors

    private TypeData(Type type) {
			Type = type;

			// Get the member configurations, and collect a parameterless constructor on the way.
			OrderedNodes = new SortedDictionary<int, MemberData>();
			UnorderedNodes = new SortedList<string, MemberData>(StringComparer.Ordinal);
			OrderedAttributes = new SortedDictionary<int, MemberData>();
			UnorderedAttributes = new SortedList<string, MemberData>(StringComparer.Ordinal);

			foreach (var member in Type.GetMembers(
					BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)) {
				switch (member) {
					case ConstructorInfo constructorInfo:
						if (constructorInfo.GetParameters().Length == 0)
							Constructor = constructorInfo;
						break;

					case FieldInfo field:
						ValidateFieldInfo(field);
						break;

					case PropertyInfo property:
						ValidatePropertyInfo(property);
						break;
				}
			}
		}

		#endregion Private Constructors

		#region Private Methods

		private void ValidateFieldInfo(FieldInfo field) {
			// Get a possible binary member configuration or use the default one.
			var attrib = field.GetCustomAttribute<BinaryContentAttribute>();
			var hasAttrib = attrib != null;
			attrib ??= new BinaryContentAttribute();

			// Field must be decorated or public.
			if (hasAttrib && field.IsPublic) {
				// Store member in a deterministic order.
				var memberData = new MemberData(field, field.FieldType, attrib);
				if ((attrib.NodeType & BinaryContentTypes.Node) != 0) {
					if (attrib.Order == int.MinValue)
						UnorderedNodes.Add(attrib.Name ?? field.Name, memberData);
					else
						OrderedNodes.Add(attrib.Order, memberData);
				}
				else if ((attrib.NodeType & BinaryContentTypes.Attribute) != 0) {
					if (attrib.Order == int.MinValue)
						UnorderedAttributes.Add(attrib.Name ?? field.Name, memberData);
					else
						OrderedAttributes.Add(attrib.Order, memberData);
				}
			}
		}

		private void ValidatePropertyInfo(PropertyInfo prop) {
			// Get a possible binary member configuration or use the default one.
			var attrib = prop.GetCustomAttribute<BinaryContentAttribute>();
			var hasAttrib = attrib != null;
			attrib ??= new BinaryContentAttribute();

			// Property must have getter and setter - if not, throw an exception if it is explicitly decorated.
			if (hasAttrib && (prop.GetMethod == null || prop.SetMethod == null)) {
				throw new InvalidOperationException($"Getter and setter on property {prop} not found.");
			}
			// Property must be decorated or getter and setter public.
			if (hasAttrib
					&& prop.GetMethod?.IsPublic == true && prop.SetMethod?.IsPublic == true) {
				// Store member in a deterministic order.
				var memberData = new MemberData(prop, prop.PropertyType, attrib);
				if ((attrib.NodeType & BinaryContentTypes.Node) != 0) {
					if (attrib.Order == int.MinValue)
						UnorderedNodes.Add(attrib.Name ?? prop.Name, memberData);
					else
						OrderedNodes.Add(attrib.Order, memberData);
				}
				else if ((attrib.NodeType & BinaryContentTypes.Attribute) != 0) {
					if (attrib.Order == int.MinValue) {
            try {
						UnorderedAttributes.Add(attrib.Name ?? prop.Name, memberData);

						}
						catch (Exception) {

							throw;
						}
          }
          else {
            OrderedAttributes.Add(attrib.Order, memberData);
          }
        }
			}
		}

		#endregion Private Methods

		#region Private Fields

		private static readonly ConcurrentDictionary<Type, TypeData> _cache = new ConcurrentDictionary<Type, TypeData>();

		#endregion Private Fields
	}
}