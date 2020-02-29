using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaItemManager {

    [BinaryContent(Name = "AreaSlotContainer", NodeType = BinaryContentTypes.Node)]
    public AreaSlotContainer AreaSlotContainer { get; set; }

  }
}