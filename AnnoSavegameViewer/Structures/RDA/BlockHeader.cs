namespace AnnoSavegameViewer.Structures.RDA {
  using AnnoSavegameViewer.Serialization.Memory;

  public class BlockHeader {

    #region Public Properties

    public BlockFlags Flags { get; set; }
    public int NumberOfFiles { get; set; }
    public ulong CompressedSize { get; set; }
    public ulong UncompressedSize { get; set; }
    public ulong NextHeaderOffset { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public BlockHeader(ref MemoryReader reader) {
      Flags = reader.ReadEnum<BlockFlags>();
			NumberOfFiles = reader.ReadInt32();
      CompressedSize = reader.ReadUInt64();
			UncompressedSize = reader.ReadUInt64();
			NextHeaderOffset = reader.ReadUInt64();
		}

    #endregion Public Constructors
  }
}