using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectGroupFilterCollection {

    [BinaryContent(Name = "Root", NodeType = BinaryContentTypes.Node)]
    public Root Root { get; set; }

  }
}