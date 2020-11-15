namespace AnnoSerializer.Serialization.Reflection.TypeData {
  using AnnoSerializer.Serialization.Core;
  using System;
  using System.Diagnostics;
  using System.Reflection;

  /// <summary> Represents information on a member of a type cached as <see cref="TypeData"/>. </summary>
  [DebuggerDisplay(nameof(MemberData) + " " + nameof(MemberInfo) + "={" + nameof(MemberInfo) + "}")]
  public class MemberData {

    #region Internal Properties

    /// <summary> Gets the <see cref="MemberInfo"/> represented. </summary>
    internal MemberInfo MemberInfo { get; }

    /// <summary> Gets the <see cref="Type"/> of the value stored by the member. </summary>
    internal Type Type { get; }

    /// <summary> Gets the <see cref="BinaryContentAttribute"/> configuration. </summary>
    internal BinaryContentAttribute Attribute { get; }

    #endregion Internal Properties

    /// <summary>
    /// Initializes a new instance of the <see cref="MemberData"/> class for the given <paramref
    /// name="memberInfo"/> with the specified <paramref name="attribute"/> configuration.
    /// </summary>
    /// <param name="memberInfo"> The <see cref="MemberData"/> to represent. </param>
    /// <param name="type"> The type of the value stored by the member. </param>
    /// <param name="attribute"> The <see cref="BinaryContentAttribute"/> configuration. </param>
    internal MemberData(MemberInfo memberInfo, Type type, BinaryContentAttribute attribute) {
      MemberInfo = memberInfo;
      Type = type;
      Attribute = attribute;
    }
  }
}