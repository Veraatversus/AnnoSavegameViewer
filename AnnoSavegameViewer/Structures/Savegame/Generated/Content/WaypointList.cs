using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WaypointList {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "IsSessionSwitch", NodeType = BinaryContentTypes.Attribute)]
    public object IsSessionSwitch { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

  }
}