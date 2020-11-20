// Copyright © 2020 Vera@Versus. All rights reserved. Licensed under the MIT License.

namespace AnnoSerializer.Serialization.Core {

  /// <summary> Represents formats of binary char encodings. </summary>
  public enum CharPattern {

    /// <summary> A character has a size of 1 <see cref="byte"./> </summary>
    ByteChar,

    /// <summary> A character has a size of 2 <see cref="byte"./> </summary>
    Int16Char,

    /// <summary> A character has a size of 4 <see cref="byte"./> </summary>
    Int32Char,
  }
}