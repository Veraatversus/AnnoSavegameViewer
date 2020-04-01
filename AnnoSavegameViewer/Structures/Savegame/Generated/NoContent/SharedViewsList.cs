using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SharedViewsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SharedViewsListValue Value { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SharedViewsListList> SharedViewsListList { get; set; }

  }
}