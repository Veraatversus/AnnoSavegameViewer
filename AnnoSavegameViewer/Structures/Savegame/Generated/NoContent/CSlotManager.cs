using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CSlotManager {

    [BinaryContent(Name = "SnapPartner", NodeType = BinaryContentTypes.Node)]
    public SnapPartner SnapPartner { get; set; }

  }
}