namespace AnnoSavegameViewer.Serialization.Core {
  using System;

  /// <summary> Represents utilities for working with <see cref="Endian"/> instances. </summary>
  public static class EndianTools {

    #region Public Fields

    /// <summary> The <see cref="Endian"/> representing system endianness. </summary>
    public static readonly Endian SystemEndian = BitConverter.IsLittleEndian ? Endian.Little : Endian.Big;

    /// <summary> The <see cref="Endian"/> not representing system endianness. </summary>
    public static readonly Endian NonSystemEndian = BitConverter.IsLittleEndian ? Endian.Big : Endian.Little;

    #endregion Public Fields
  }
}