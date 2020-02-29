using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Residence7 {

    [BinaryContent(Name = "ResidentCount", NodeType = BinaryContentTypes.Attribute)]
    public object ResidentCount { get; set; }

    [BinaryContent(Name = "TimeBeforeRuinLeft", NodeType = BinaryContentTypes.Attribute)]
    public object TimeBeforeRuinLeft { get; set; }

    [BinaryContent(Name = "PopulationMoveTimeout", NodeType = BinaryContentTypes.Attribute)]
    public object PopulationMoveTimeout { get; set; }

    [BinaryContent(Name = "ProductMoneyOutput", NodeType = BinaryContentTypes.Attribute)]
    public object ProductMoneyOutput { get; set; }

    [BinaryContent(Name = "AverageNeedSaturation", NodeType = BinaryContentTypes.Attribute)]
    public object AverageNeedSaturation { get; set; }

    [BinaryContent(Name = "Influence", NodeType = BinaryContentTypes.Attribute)]
    public object Influence { get; set; }

    [BinaryContent(Name = "ResidenceState", NodeType = BinaryContentTypes.Node)]
    public ResidenceState ResidenceState { get; set; }

    [BinaryContent(Name = "ConsumptionStates", NodeType = BinaryContentTypes.Node)]
    public ConsumptionStates ConsumptionStates { get; set; }

  }
}