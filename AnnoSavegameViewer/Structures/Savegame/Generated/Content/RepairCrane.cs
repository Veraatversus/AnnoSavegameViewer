using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RepairCrane {

    [BinaryContent(Name = "currentRepairTarget", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentRepairTarget { get; set; }

  }
}