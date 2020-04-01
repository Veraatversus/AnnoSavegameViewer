using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BaseNode {

    [BinaryContent(Name = "MetaGameManager", NodeType = BinaryContentTypes.Node)]
    public MetaGameManager MetaGameManager { get; set; }

  }
}