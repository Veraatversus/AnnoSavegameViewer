namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RepairCrane {

    [BinaryContent(Name = "currentRepairTarget", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentRepairTarget { get; set; }

  }
}