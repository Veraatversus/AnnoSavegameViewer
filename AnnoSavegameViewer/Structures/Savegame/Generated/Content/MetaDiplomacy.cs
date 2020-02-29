using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaDiplomacy {

    [BinaryContent(Name = "MemoryTick", NodeType = BinaryContentTypes.Attribute)]
    public object MemoryTick { get; set; }

    [BinaryContent(Name = "GeneralTick", NodeType = BinaryContentTypes.Attribute)]
    public object GeneralTick { get; set; }

    [BinaryContent(Name = "NextMilitaryPaMSyTick", NodeType = BinaryContentTypes.Attribute)]
    public object NextMilitaryPaMSyTick { get; set; }

    [BinaryContent(Name = "LivingTime", NodeType = BinaryContentTypes.Attribute)]
    public object LivingTime { get; set; }

    [BinaryContent(Name = "CounterIDLast", NodeType = BinaryContentTypes.Attribute)]
    public object CounterIDLast { get; set; }

    [BinaryContent(Name = "DiplomaticRelations", NodeType = BinaryContentTypes.Node)]
    public DiplomaticRelations DiplomaticRelations { get; set; }

    [BinaryContent(Name = "Allies", NodeType = BinaryContentTypes.Node)]
    public Allies Allies { get; set; }

    [BinaryContent(Name = "DiscoveredParticipants", NodeType = BinaryContentTypes.Node)]
    public DiscoveredParticipants DiscoveredParticipants { get; set; }

    [BinaryContent(Name = "LastAttacker", NodeType = BinaryContentTypes.Node)]
    public LastAttacker LastAttacker { get; set; }

    [BinaryContent(Name = "CounterProposal", NodeType = BinaryContentTypes.Node)]
    public CounterProposal CounterProposal { get; set; }

  }
}