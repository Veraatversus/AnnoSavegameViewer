using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BonusIncidentChanceList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public BonusIncidentChanceListValue Value { get; set; }

  }
}