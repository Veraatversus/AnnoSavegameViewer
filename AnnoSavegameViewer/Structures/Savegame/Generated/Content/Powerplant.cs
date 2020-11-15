namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Powerplant {

    [BinaryContent(Name = "IsActive", NodeType = BinaryContentTypes.Attribute)]
    public object IsActive { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public PowerplantProductionState ProductionState { get; set; }

  }
}