using AnnoSavegameViewer.Serialization.Memory;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.RDA {

  public class Block {

    #region Public Properties

    public List<File> Files { get; }
    public MemoryResisdentInfo MemoryResisdentInfo { get; }
    public BlockHeader Header { get; }

    #endregion Public Properties

    #region Public Constructors

    public Block(ref MemoryReader reader, int HeaderOffset) {
      reader.Position = HeaderOffset;
      Header = new BlockHeader(ref reader);

      reader.Position = HeaderOffset;
      MemoryResisdentInfo = default;
      if (Header.Flags.HasFlag(BlockFlags.MemoryResistent)) {
        reader.Position -= 16;
        MemoryResisdentInfo = new MemoryResisdentInfo(ref reader);
        reader.Position -= 16;
      }

      Files = new List<File>();
      reader.Position -= Header.NumberOfFiles * 560;
      for (var i = 0; i < Header.NumberOfFiles; i++) {
        Files.Add(new File(ref reader));
      }
    }

    #endregion Public Constructors
  }
}