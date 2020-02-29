namespace AnnoSavegameViewer.Serialization.Core {

  public enum BoolPattern {

    /// <summary>
    /// The boolean is stored in 1 byte and is <see langword="true"/> when the value is not 0. This
    /// is the .NET default.
    /// </summary>
    Byte,

    /// <summary>
    /// The boolean is stored in 2 bytes and is <see langword="true"/> when the value is not 0.
    /// </summary>
    Word,

    /// <summary>
    /// The boolean is stored in 4 bytes and is <see langword="true"/> when the value is not 0.
    /// </summary>
    Dword
  }
}