using System;

namespace AnnoSavegameViewer.Serialization.Core {

  /// <summary>
  /// Represents formats of binary char encodings.
  /// </summary>
  public enum CharPattern {

    /// <summary> A character has a size of 1 <see cref="Byte"./> </summary>
    ByteChar,

    /// <summary> A character has a size of 2 <see cref="Byte"./> </summary>
    Int16Char,

    /// <summary> A character has a size of 4 <see cref="Byte"./> </summary>
    Int32Char,
  }
}