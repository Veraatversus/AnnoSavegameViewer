namespace AnnoSavegameViewer.Structures.RDA {
  using AnnoSavegameViewer.Serialization.Memory;
  using System.Collections.Generic;

  public class RdaBlock {

    #region Public Properties

    public List<RdaFile> Files { get; }
    public MemoryResisdentInfo MemoryResisdentInfo { get; }
    public BlockHeader Header { get; }
    public int Index { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public RdaBlock(ref MemoryReader reader, int HeaderOffset) {
      reader.Position = HeaderOffset;
      Header = new BlockHeader(ref reader);

      reader.Position = HeaderOffset;
      MemoryResisdentInfo = default;
      if ((Header.Flags & BlockFlags.MemoryResistent) == BlockFlags.MemoryResistent) {
        reader.Position -= Constant.MemoryResisdentInfoSize;
        MemoryResisdentInfo = new MemoryResisdentInfo(ref reader);
        reader.Position -= Constant.MemoryResisdentInfoSize;
      }

      Files = new List<RdaFile>();
      var startPosition = reader.Position;
      reader.Position = startPosition - (int)Header.CompressedSize;
      for (var i = 0; i < Header.NumberOfFiles; i++) {
        Files.Add(new RdaFile(ref reader, Header));
      }
    }

    #endregion Public Constructors
  }
}