using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Serialization.Memory;
using System;
using System.Text;

namespace AnnoSavegameViewer.Structures.RDA {

  public class RdaHeader {

    #region Public Properties

    public string Magic { get; set; }
    public ReadOnlyMemory<byte> Unknown { get; set; }
    public ulong FirstBlockHeaderOffset { get; set; }

    #endregion Public Properties

    #region Public Constructors

    public RdaHeader(ref MemoryReader reader) {
      Magic = reader.ReadString(Encoding.UTF8, StringPattern.FixCharCount, 18);// .ReadStringRaw(18);
      Unknown = reader.Memory[..766];
      reader.Position += 766;
      FirstBlockHeaderOffset = reader.ReadUInt64();
    }

    #endregion Public Constructors
  }
}