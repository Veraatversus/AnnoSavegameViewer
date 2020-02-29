using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IslandSize {

    [BinaryContent(Name = "islandSize", NodeType = BinaryContentTypes.Attribute)]
    public object IslandSizeItem { get; set; }

  }
}