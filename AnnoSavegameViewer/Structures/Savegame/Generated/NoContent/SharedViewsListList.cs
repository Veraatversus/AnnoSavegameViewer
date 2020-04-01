using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SharedViewsListList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SharedViewsListListValue Value { get; set; }

  }
}