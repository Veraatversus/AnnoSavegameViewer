using AnnoSavegameViewer.Serialization.Memory;
using System;

namespace AnnoSavegameViewer.Structures.A7S {

  public class A7S : RDA.RDA {

    #region Public Properties

    public ReadOnlyMemory<byte> A7SMeta { get; set; }
    public ReadOnlyMemory<byte> A7SHeader { get; set; }
    public ReadOnlyMemory<byte> A7SGameSetup { get; set; }
    public ReadOnlyMemory<byte> A7SData { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public A7S(ref MemoryReader reader) : base(ref reader) {
      A7SMeta = Blocks[0].Files[0].FileData;
      A7SHeader = Blocks[1].Files[0].FileData;
      A7SGameSetup = Blocks[2].Files[0].FileData;
      A7SData = Blocks[3].Files[0].FileData;
    }

    #endregion Public Constructors
  }
}