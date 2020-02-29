using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GroupHandler {

    [BinaryContent(Name = "NextGroupID", NodeType = BinaryContentTypes.Attribute)]
    public object NextGroupID { get; set; }

    [BinaryContent(Name = "Groups", NodeType = BinaryContentTypes.Node)]
    public Groups Groups { get; set; }

  }
}