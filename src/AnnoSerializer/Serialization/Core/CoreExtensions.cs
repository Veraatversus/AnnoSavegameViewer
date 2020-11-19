// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Core {

  using System;
  using System.Globalization;
  using System.Linq;
  using System.Text;

  public static class CoreExtensions {

    #region Public Methods

    public static string UppercaseFirst(this string s) {
      if (string.IsNullOrEmpty(s)) {
        return string.Empty;
      }
      var a = s.ToCharArray();
      a[0] = char.ToUpper(a[0], CultureInfo.CurrentCulture);
      return new string(a);
    }

    public static string ToTypeString(this Type type) {
      var name = type.Name;
      var index = type.Name.IndexOf("`", StringComparison.Ordinal);
      if (index >= 0) {
        name = name.Remove(index);
      }

      if (type.IsGenericType) {
        name += $"<{string.Join(", ", type.GenericTypeArguments.Select(a => a.ToTypeString()))}>";
      }
      return name;
    }

    public static string ToAttributeDecorationString(this BinaryContentAttribute attribute) {
      var sb = new StringBuilder();
      _ = sb.Append("[BinaryContent(");

      _ = sb.Append(nameof(attribute.Name)).Append(" = ").Append('"').Append(attribute.Name).Append('"');

      if (attribute.NodeType != default) {
        _ = sb.Append(", ").Append(nameof(attribute.NodeType)).Append(" = ").Append("BinaryContentTypes.").Append(attribute.NodeType);
      }

      if (attribute.BoolPattern != default) {
        _ = sb.Append(", ").Append(nameof(attribute.BoolPattern)).Append(" = ").Append("BoolPattern.").Append(attribute.BoolPattern);
      }

      if (attribute.CompressionType != default) {
        _ = sb.Append(", ").Append(nameof(attribute.CompressionType)).Append(" = ").Append("CompressionTypes.").Append(attribute.CompressionType);
      }

      if (attribute.ConversationType != default) {
        _ = sb.Append(", ").Append(nameof(attribute.ConversationType)).Append(" = ").Append("ConversationTypes.").Append(attribute.ConversationType);
      }

      if (attribute.DateTimePattern != default) {
        _ = sb.Append(", ").Append(nameof(attribute.DateTimePattern)).Append(" = ").Append("DateTimePattern.").Append(attribute.DateTimePattern);
      }

      if (attribute.Encoding != default) {
        _ = sb.Append(", ").Append(nameof(attribute.Encoding)).Append(" = ").Append('"').Append(attribute.Encoding).Append('"');
      }

      if (attribute.Endian != default) {
        _ = sb.Append(", ").Append(nameof(attribute.Endian)).Append(" = ").Append("Endian.").Append(attribute.Endian);
      }

      if (attribute.Length != default) {
        _ = sb.Append(", ").Append(nameof(attribute.Length)).Append(" = ").Append(attribute.Length);
      }

      if (attribute.Offset != default) {
        _ = sb.Append(", ").Append(nameof(attribute.Offset)).Append(" = ").Append(attribute.Offset);
      }

      if (attribute.Order != int.MinValue) {
        _ = sb.Append(", ").Append(nameof(attribute.Order)).Append(" = ").Append(attribute.Order);
      }

      if (attribute.RdaBlock != -1) {
        _ = sb.Append(", ").Append(nameof(attribute.RdaBlock)).Append(" = ").Append(attribute.RdaBlock);
      }

      if (attribute.RdaFile != default) {
        _ = sb.Append(", ").Append(nameof(attribute.RdaFile)).Append(" = ").Append('"').Append(attribute.RdaFile).Append('"');
      }

      if (attribute.Strict != default) {
        _ = sb.Append(", ").Append(nameof(attribute.Strict)).Append(" = ").Append(attribute.Strict);
      }

      if (attribute.StringPattern != default) {
        _ = sb.Append(", ").Append(nameof(attribute.StringPattern)).Append(" = ").Append("StringPattern.").Append(attribute.StringPattern);
      }

      if (attribute.TimeSpanPattern != default) {
        _ = sb.Append(", ").Append(nameof(attribute.TimeSpanPattern)).Append(" = ").Append("TimeSpanPattern.").Append(attribute.TimeSpanPattern);
      }

      _ = sb.Append(")]");
      return sb.ToString();
    }

    #endregion Public Methods
  }
}