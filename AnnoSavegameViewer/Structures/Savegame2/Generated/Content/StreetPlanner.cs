namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class StreetPlanner {

    [BinaryContent(Name = "StreetUpgradeTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object StreetUpgradeTimestamp { get; set; }

    [BinaryContent(Name = "StreetUpgradeAreas", NodeType = BinaryContentTypes.Node)]
    public StreetUpgradeAreas StreetUpgradeAreas { get; set; }

    [BinaryContent(Name = "Bridges", NodeType = BinaryContentTypes.Node)]
    public Bridges Bridges { get; set; }

  }
}