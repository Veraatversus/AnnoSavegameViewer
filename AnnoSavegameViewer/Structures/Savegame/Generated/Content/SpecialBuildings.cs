using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpecialBuildings {

    [BinaryContent(Name = "CultureItemCheatTime", NodeType = BinaryContentTypes.Attribute)]
    public object CultureItemCheatTime { get; set; }

    [BinaryContent(Name = "NextSpecialBuildingTick", NodeType = BinaryContentTypes.Attribute)]
    public object NextSpecialBuildingTick { get; set; }

    [BinaryContent(Name = "MonumentHandler", NodeType = BinaryContentTypes.Node)]
    public MonumentHandler MonumentHandler { get; set; }

  }
}