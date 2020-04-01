using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SyncedStatesArrayListView {

    [BinaryContent(Name = "From", NodeType = BinaryContentTypes.Attribute)]
    public object From { get; set; }

    [BinaryContent(Name = "At", NodeType = BinaryContentTypes.Attribute)]
    public object At { get; set; }

    [BinaryContent(Name = "Up", NodeType = BinaryContentTypes.Attribute)]
    public object Up { get; set; }

    [BinaryContent(Name = "Direction", NodeType = BinaryContentTypes.Attribute)]
    public object Direction { get; set; }

  }
}