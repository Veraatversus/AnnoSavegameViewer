namespace AnnoSavegameViewer.Serialization.Core {

  /// <summary> Represents formats of binary string encodings. </summary>
  public enum StringPattern {

    /// <summary>
    /// The string has neither prefix nor postfix. The byte count has to be specified manually.
    /// </summary>
    FixByteCount,

    /// <summary>
    /// The string has a prefix of a 7-bit encoded integer of variable size determining the number
    /// of bytes out of which the string consists and no postfix. This is the .NET <see
    /// cref="System.IO.BinaryReader"/> and <see cref="System.IO.BinaryWriter"/> default.
    /// </summary>
    VariableByteCount,

    /// <summary>
    /// The string has a prefix of 1 byte determining the number of chars out of which the string
    /// consists and no postfix.
    /// </summary>
    ByteCharCount,

    /// <summary>
    /// The string has a prefix of 2 bytes determining the number of chars out of which the string
    /// consists and no postfix.
    /// </summary>
    Int16CharCount,

    /// <summary>
    /// The string has a prefix of 4 bytes determining number of chars out of which the string
    /// consists and no postfix.
    /// </summary>
    Int32CharCount,

    /// <summary>
    /// The string has no prefix and is terminated with a 0 value. The size of this value depends on
    /// the encoding.
    /// </summary>
    ZeroTerminated,

    /// <summary>
    /// The string has neither prefix nor postfix. The char count has to be specified manually.
    /// </summary>
    FixCharCount
  }
}