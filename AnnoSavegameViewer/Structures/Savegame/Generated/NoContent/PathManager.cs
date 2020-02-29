using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PathManager {

    [BinaryContent(Name = "GroupHandler", NodeType = BinaryContentTypes.Node)]
    public GroupHandler GroupHandler { get; set; }

  }
}