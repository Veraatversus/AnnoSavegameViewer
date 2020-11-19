namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DiplomaticRelationsList {

    [BinaryContent(Name = "Reputation", NodeType = BinaryContentTypes.Attribute)]
    public object Reputation { get; set; }

    [BinaryContent(Name = "ReputationMemory", NodeType = BinaryContentTypes.Attribute)]
    public object ReputationMemory { get; set; }

    [BinaryContent(Name = "MemoryTime", NodeType = BinaryContentTypes.Attribute)]
    public object MemoryTime { get; set; }

    [BinaryContent(Name = "m_DiscoverTime", NodeType = BinaryContentTypes.Attribute)]
    public object M_DiscoverTime { get; set; }

    [BinaryContent(Name = "RepeatableActionZero", NodeType = BinaryContentTypes.Attribute)]
    public object RepeatableActionZero { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DiplomaticRelationsListValue Value { get; set; }

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public Source Source { get; set; }

    [BinaryContent(Name = "Destination", NodeType = BinaryContentTypes.Node)]
    public Destination Destination { get; set; }

    [BinaryContent(Name = "DiplomacyStates", NodeType = BinaryContentTypes.Node)]
    public DiplomacyStates DiplomacyStates { get; set; }

    [BinaryContent(Name = "Debuffs", NodeType = BinaryContentTypes.Node)]
    public Debuffs Debuffs { get; set; }

    [BinaryContent(Name = "ReputationHistory", NodeType = BinaryContentTypes.Node)]
    public ReputationHistory ReputationHistory { get; set; }

    [BinaryContent(Name = "m_TriggerTimes", NodeType = BinaryContentTypes.Node)]
    public M_TriggerTimes M_TriggerTimes { get; set; }
  }
}