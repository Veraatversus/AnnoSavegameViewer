using AnnoSavegameViewer.Serialization.Memory;
using System;

namespace AnnoSavegameViewer.Structures.RDA {

  public class File {

    #region Public Properties

    public ReadOnlyMemory<byte> FileData { get; set; }
    public FileHeader FileHeader { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public File(ref MemoryReader reader) {
      FileHeader = new FileHeader(ref reader);
      FileData = reader.Memory.Slice((int)FileHeader.DataOffset, (int)FileHeader.CompressedSize);
    }

    #endregion Public Constructors
  }
}