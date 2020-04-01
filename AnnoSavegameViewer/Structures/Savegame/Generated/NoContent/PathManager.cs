using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PathManager {

    [BinaryContent(Name = "GroupHandler", NodeType = BinaryContentTypes.Node)]
    public GroupHandler GroupHandler { get; set; }

  }
}