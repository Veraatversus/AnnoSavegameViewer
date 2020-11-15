namespace AnnoSerializer.Structures.A7S {
  using AnnoSerializer.Serialization.Memory;
  using System;

  public class A7SFormat : RDA.Rda {

    #region Public Properties

    public ReadOnlyMemory<byte> A7SMeta { get; set; }
    public ReadOnlyMemory<byte> A7SHeader { get; set; }
    public ReadOnlyMemory<byte> A7SGameSetup { get; set; }
    public ReadOnlyMemory<byte> A7SData { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public A7SFormat(ref MemoryReader reader) : base(ref reader) {
      A7SMeta = Blocks[0].Files[0].FileData;
      A7SHeader = Blocks[1].Files[0].FileData;
      A7SGameSetup = Blocks[2].Files[0].FileData;
      A7SData = Blocks[3].Files[0].FileData;
    }

    #endregion Public Constructors

    #region Public Methods

    public static A7SFormat FromFile(string path) {
      var bytes = System.IO.File.ReadAllBytes(path);
      var reader = new MemoryReader(bytes);
      return new A7SFormat(ref reader);
    }

    #endregion Public Methods
  }
}