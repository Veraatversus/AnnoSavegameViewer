using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MapSize {

    [BinaryContent(Name = "mapSize", NodeType = BinaryContentTypes.Attribute)]
    public object MapSizeItem { get; set; }

  }
}