using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PathBackground {

    [BinaryContent(Name = "CurrentPath", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentPath { get; set; }

  }
}