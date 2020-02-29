using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VerticalEdgesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VerticalEdgesListList> VerticalEdgesListList { get; set; }

  }
}