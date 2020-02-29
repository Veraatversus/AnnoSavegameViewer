using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaIncidentManager {

    [BinaryContent(Name = "BonusIncidentChance", NodeType = BinaryContentTypes.Node)]
    public BonusIncidentChance BonusIncidentChance { get; set; }

    [BinaryContent(Name = "IncidentInterval", NodeType = BinaryContentTypes.Node)]
    public IncidentInterval IncidentInterval { get; set; }

  }
}