using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GridList {

    [BinaryContent(Name = "FreeTiles", NodeType = BinaryContentTypes.Attribute)]
    public object FreeTiles { get; set; }

    [BinaryContent(Name = "DistanceToBlocker", NodeType = BinaryContentTypes.Attribute)]
    public object DistanceToBlocker { get; set; }

  }
}