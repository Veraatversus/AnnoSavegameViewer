using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NotificationSystem {

    [BinaryContent(Name = "IDCounter", NodeType = BinaryContentTypes.Attribute)]
    public object IDCounter { get; set; }

    [BinaryContent(Name = "LocalPeer", NodeType = BinaryContentTypes.Node)]
    public LocalPeer LocalPeer { get; set; }

    [BinaryContent(Name = "Queue", NodeType = BinaryContentTypes.Node)]
    public Queue Queue { get; set; }

    [BinaryContent(Name = "Archive", NodeType = BinaryContentTypes.Node)]
    public Archive Archive { get; set; }

    [BinaryContent(Name = "FilterArrays", NodeType = BinaryContentTypes.Node)]
    public FilterArrays FilterArrays { get; set; }

  }
}