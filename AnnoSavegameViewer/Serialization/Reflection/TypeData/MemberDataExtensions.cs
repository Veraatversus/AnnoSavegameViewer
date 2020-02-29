﻿using AnnoSavegameViewer.Serialization.Core;
using System;
using System.Reflection;

namespace AnnoSavegameViewer.Serialization.Reflection.TypeData {

  public static class MemberDataExtensions {

    #region Public Methods

    public static bool IsDataRequested(this MemberData memberData, string key, BinaryContentTypes nodeType) {
      if (memberData?.Attribute.NodeType == nodeType || memberData?.Attribute.NodeType == BinaryContentTypes.Both) {
        if (memberData.Attribute.Name is string name) {
          return name.Equals(key, StringComparison.Ordinal);
        }
        else {
          return memberData.MemberInfo.Name.Equals(key, StringComparison.Ordinal);
        }
      }
      return false;
    }

    public static void SetMemberValue(this MemberInfo memberInfo, object instance, object value) {
      switch (memberInfo) {
        case FieldInfo field:
          field.SetValue(instance, value);
          break;

        case PropertyInfo property:
          property.SetValue(instance, value);
          break;
      }
    }

    public static object GetMemberValue(this MemberInfo memberInfo, object instance) {
      switch (memberInfo) {
        case FieldInfo field:
          return field.GetValue(instance);

        case PropertyInfo property:
          return property.GetValue(instance);
      }
      return null;
    }

    #endregion Public Methods
  }
}