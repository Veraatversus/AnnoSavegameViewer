using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HeatProvider {

    [BinaryContent(Name = "TransporterRange", NodeType = BinaryContentTypes.Attribute)]
    public object TransporterRange { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public ProductionState ProductionState { get; set; }

  }
}