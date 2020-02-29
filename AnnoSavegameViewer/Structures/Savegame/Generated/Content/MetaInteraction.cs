using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaInteraction {

    [BinaryContent(Name = "NextMilitaryCalculation", NodeType = BinaryContentTypes.Attribute)]
    public object NextMilitaryCalculation { get; set; }

    [BinaryContent(Name = "NextWorkingConditionsEvaluation", NodeType = BinaryContentTypes.Attribute)]
    public object NextWorkingConditionsEvaluation { get; set; }

    [BinaryContent(Name = "LastMilitaryValue", NodeType = BinaryContentTypes.Attribute)]
    public object LastMilitaryValue { get; set; }

    [BinaryContent(Name = "PropagandaChances", NodeType = BinaryContentTypes.Node)]
    public PropagandaChances PropagandaChances { get; set; }

    [BinaryContent(Name = "CurrentTradeStatus", NodeType = BinaryContentTypes.Node)]
    public CurrentTradeStatus CurrentTradeStatus { get; set; }

    [BinaryContent(Name = "LastMilitaryRange", NodeType = BinaryContentTypes.Node)]
    public LastMilitaryRange LastMilitaryRange { get; set; }

    [BinaryContent(Name = "LastPollutionMessage", NodeType = BinaryContentTypes.Node)]
    public LastPollutionMessage LastPollutionMessage { get; set; }

    [BinaryContent(Name = "LastAttractivenessMessage", NodeType = BinaryContentTypes.Node)]
    public LastAttractivenessMessage LastAttractivenessMessage { get; set; }

    [BinaryContent(Name = "LastWorkingConditionsEvaluation", NodeType = BinaryContentTypes.Node)]
    public LastWorkingConditionsEvaluation LastWorkingConditionsEvaluation { get; set; }

  }
}