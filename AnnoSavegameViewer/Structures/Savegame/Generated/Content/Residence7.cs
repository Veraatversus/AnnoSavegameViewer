using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

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

    [BinaryContent(Name = "NewspaperMoneyOutput", NodeType = BinaryContentTypes.Attribute)]
    public object NewspaperMoneyOutput { get; set; }

    [BinaryContent(Name = "LogisticDirty", NodeType = BinaryContentTypes.Attribute)]
    public object LogisticDirty { get; set; }

    [BinaryContent(Name = "ResidenceState", NodeType = BinaryContentTypes.Node)]
    public ResidenceState ResidenceState { get; set; }

    [BinaryContent(Name = "ConsumptionStates", NodeType = BinaryContentTypes.Node)]
    public ConsumptionStates ConsumptionStates { get; set; }

  }
}