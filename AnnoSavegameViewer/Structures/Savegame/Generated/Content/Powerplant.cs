using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Powerplant {

    [BinaryContent(Name = "IsActive", NodeType = BinaryContentTypes.Attribute)]
    public object IsActive { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public PowerplantProductionState ProductionState { get; set; }

  }
}