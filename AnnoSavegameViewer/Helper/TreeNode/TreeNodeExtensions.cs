using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.Memory;
using AnnoSavegameViewer.Serialization.Reflection.TypeData;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AnnoSavegameViewer.Helper.TreeNode {

  public static partial class TreeNodeExtensions {

    #region Public Methods

    public static T Convert<T>(this TreeNode node) {
      if (node is null) {
        throw new ArgumentNullException(nameof(node));
      }
      return (T)ReadMembers(node, typeof(T));
    }

    #endregion Public Methods

    #region Private Methods

    private static object ReadMembers(TreeNode binaryNode, Type type, object instance = null) {
      var typeData = TypeData.GetTypeData(type);
      instance ??= typeData.GetInstance();

      //Attributes
      foreach (var attributes in binaryNode.Attributes.ToLookup(a => a.Name, a => a)) {
        var count = attributes.Count();
        foreach (var member in typeData.UnorderedNodes.Values) {
          if (member.IsDataRequested(attributes.Key, BinaryContentTypes.Attribute)) {
            object value;
            var elementType = member.Type.GetFirstUnderlayingType();
            if (elementType == null) {
              value = ReadObject(attributes.First().Content.Span, member.Attribute, member.Type);
            }
            else {
              var index = 0;
              var values = Array.CreateInstance(elementType, count);
              foreach (var attribute in attributes) {
                values.SetValue(ReadObject(attribute.Content.Span, member.Attribute, elementType), index++);
              }
              value = values;
            }

            switch (member.MemberInfo) {
              case FieldInfo field:
                field.SetValue(instance, value);
                break;

              case PropertyInfo property:
                property.SetValue(instance, value);
                break;
            }
          }
        }
      }
      //Nodes
      foreach (var nodes in binaryNode.Nodes.ToLookup(a => a.Name, a => a)) {
        var count = nodes.Count();
        foreach (var member in typeData.UnorderedNodes.Values) {
          if (member.IsDataRequested(nodes.Key, BinaryContentTypes.Node)) {
            object value;
            var elementType = member.Type.GetFirstUnderlayingType();
            if (elementType == null) {
              value = ReadMembers(nodes.First(), member.Type);
            }
            else {
              var index = 0;
              var values = Array.CreateInstance(elementType, count);
              foreach (var node in nodes) {
                values.SetValue(ReadMembers(node, elementType), index++);
              }
              value = values;
            }

            switch (member.MemberInfo) {
              case FieldInfo field:
                field.SetValue(instance, value);
                break;

              case PropertyInfo property:
                property.SetValue(instance, value);
                break;
            }
          }
        }
      }
      return instance;
    }

    private static object ReadObject(this in ReadOnlySpan<byte> span, BinaryContentAttribute attribute, Type type) {
      var encoding = attribute.Encoding != null ? Encoding.GetEncoding(attribute.Encoding) : null;
      if (type == typeof(string)) {
        var lenght = attribute.Length != 0 ? attribute.Length : span.Length - attribute.Offset;
        return span.ReadString(attribute.Offset, lenght, encoding, attribute.StringPattern);
      }
      else if (type.IsEnumerable())
        throw new InvalidOperationException("Multidimensional arrays cannot be read directly.");
      else if (type == typeof(bool))
        return span.ReadBoolean(attribute.Offset, attribute.BoolPattern);
      else if (type == typeof(byte))
        return span.ReadByte(attribute.Offset);
      else if (type == typeof(DateTime))
        return span.ReadDateTime(attribute.Offset, attribute.DateTimePattern, attribute.Endian);
      else if (type == typeof(decimal))
        return span.ReadDecimal(attribute.Offset);
      else if (type == typeof(double))
        return span.ReadDouble(attribute.Offset, attribute.Endian);
      else if (type == typeof(short))
        return span.ReadInt16(attribute.Offset, attribute.Endian);
      else if (type == typeof(int))
        return span.ReadInt32(attribute.Offset, attribute.Endian);
      else if (type == typeof(long))
        return span.ReadInt64(attribute.Offset, attribute.Endian);
      else if (type == typeof(sbyte))
        return span.ReadSByte(attribute.Offset);
      else if (type == typeof(float))
        return span.ReadSingle(attribute.Offset, attribute.Endian);
      else if (type == typeof(ushort))
        return span.ReadUInt16(attribute.Offset, attribute.Endian);
      else if (type == typeof(uint))
        return span.ReadUInt32(attribute.Offset, attribute.Endian);
      else if (type == typeof(ulong))
        return span.ReadUInt64(attribute.Offset, attribute.Endian);
      //else if (type == typeof(Point2DInt))
      //  return span.ReadPoint(attribute.Offset, attribute.Endian);
      ////else if (type == typeof(Point3DInt))
      ////  return span.ReadPoint(attribute.Offset, attribute.Endian);
      else if (type.IsEnum)
        return span.ReadEnum(type, attribute.Strict, attribute.Offset, attribute.Endian);
      else if (type == typeof(object))
        return span.ReadBytes(span.Length - attribute.Offset, attribute.Offset, attribute.Endian);
      else
        //return ReadCustomObject(type);
        throw new NotSupportedException($"Following property type is not supported \"{type.AssemblyQualifiedName}\".");
    }

    #endregion Private Methods

    //private static object ReadCustomObject(this in MemoryReader reader, Type type) {
    //  TypeData typeData = TypeData.GetTypeData(type);
    //  instance ??= typeData.GetInstance();
    //  span.
    //  foreach (var orderedMember in typeData.OrderedMembers) {
    //    ReadMember(stream, instance, startOffset, converter, orderedMember.Value);
    //  }
    //  foreach (var unorderedMember in typeData.UnorderedMembers) {
    //    ReadMember(stream, instance, startOffset, converter, unorderedMember.Value);
    //  }
    //}
  }
}