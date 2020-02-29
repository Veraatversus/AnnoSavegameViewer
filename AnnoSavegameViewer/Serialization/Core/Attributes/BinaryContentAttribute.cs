using System;
using System.Collections;
using System.Text;

namespace AnnoSavegameViewer.Serialization.Core {

  /// <summary>
  /// Represents a member configuration for reading and writing it as binary data.
  /// </summary>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class BinaryContentAttribute : Attribute {

    #region Public Properties

    /// <summary>
    /// Gets or sets the format for <see cref="bool"/> members. Defaults to <see cref="BoolPattern.Byte"/>.
    /// </summary>
    public BoolPattern BoolPattern { get; set; }

    /// <summary>
    /// Gets or sets the format for <see cref="DateTime"/> members. Defaults to <see cref="DateTimePattern.NetTicks"/>.
    /// </summary>
    public DateTimePattern DateTimePattern { get; set; }

    /// <summary>
    /// Gets or sets the encoding for <see cref="string"/> members. Defaults to <see
    /// cref="Encoding.UTF8"/> (utf-8).
    /// </summary>
    public string Encoding { get; set; }

    /// <summary>
    /// Gets or sets the Endian for type members. Defaults to <see cref="Endian.System"/>.
    /// </summary>
    public Endian Endian { get; set; }

    /// <summary>
    /// Gets or sets the number of elements to read or write. Required for <see cref="IEnumerable"/>
    /// members or strings when <see cref="StringCoding"/> is <see cref="StringCoding.Raw"/>.
    /// Multidimensional arrays are not supported.
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Gets or sets the matching Name represented in the binary for this. Defaults to <see langword="null"/>.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="BinaryContentTypes"/> Name represented in the binary for this.
    /// Defaults to <see cref="BinaryContentTypes.Both"/>.
    /// </summary>
    public BinaryContentTypes NodeType { get; set; } = BinaryContentTypes.Both;

    /// <summary>
    /// Gets or sets offset of this field in bytes. Can be negative. Defaults to 0.
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// Gets or sets the number determining the order in which the member is read or written. If not
    /// specified, the members are written in alphabetical order.
    /// </summary>
    public int Order { get; set; } = Int32.MinValue;

    /// <summary>
    /// Gets or sets a value indicating whether enum values are checked for a valid value or set of
    /// flags. Defaults to <see langword="false"/>.
    /// </summary>
    public bool Strict { get; set; }

    /// <summary>
    /// Gets or sets the format for <see cref="string"/> members. Defaults to <see cref="StringPattern.VariableByteCount"/>.
    /// </summary>
    public StringPattern StringPattern { get; set; }

    #endregion Public Properties

    #region Internal Fields

    internal static readonly BinaryContentAttribute Default = new BinaryContentAttribute();

    #endregion Internal Fields
  }
}