using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MineProhibitZones {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public MineProhibitZonesList MineProhibitZonesList { get; set; }

  }
}