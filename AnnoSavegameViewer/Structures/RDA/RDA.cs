using AnnoSavegameViewer.Serialization.Memory;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.RDA {

  public class RDA {

    #region Public Properties

    public RdaHeader RdaHeader { get; set; }
    public List<Block> Blocks { get; }

    #endregion Public Properties

    #region Public Constructors

    public RDA(ref MemoryReader reader) {
      RdaHeader = new RdaHeader(ref reader);

      Blocks = new List<Block>();
      var nextHeaderOffset = (int)RdaHeader.FirstBlockHeaderOffset;

      while (nextHeaderOffset <= reader.Length - 32) {
        var block = new Block(ref reader, nextHeaderOffset);
        Blocks.Add(block);
        nextHeaderOffset = (int)block.Header.NextHeaderOffset;
      }
    }

    #endregion Public Constructors
  }
}