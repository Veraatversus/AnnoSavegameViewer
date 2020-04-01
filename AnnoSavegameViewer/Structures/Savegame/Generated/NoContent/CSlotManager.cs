using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CSlotManager {

    [BinaryContent(Name = "SnapPartner", NodeType = BinaryContentTypes.Node)]
    public SnapPartner SnapPartner { get; set; }

  }
}