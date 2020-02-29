using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentResolver {

    [BinaryContent(Name = "specialActionCooldown", NodeType = BinaryContentTypes.Attribute)]
    public object SpecialActionCooldown { get; set; }

    [BinaryContent(Name = "pausedLastTick", NodeType = BinaryContentTypes.Attribute)]
    public object PausedLastTick { get; set; }

    [BinaryContent(Name = "resolverUnits", NodeType = BinaryContentTypes.Node)]
    public ResolverUnits ResolverUnits { get; set; }

    [BinaryContent(Name = "specialUnits", NodeType = BinaryContentTypes.Node)]
    public SpecialUnits SpecialUnits { get; set; }

  }
}