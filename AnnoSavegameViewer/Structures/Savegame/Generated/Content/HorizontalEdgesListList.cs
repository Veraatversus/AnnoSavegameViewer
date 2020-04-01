using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HorizontalEdgesListList {

    [BinaryContent(Name = "SuppressRenderUpdates", NodeType = BinaryContentTypes.Attribute)]
    public object SuppressRenderUpdates { get; set; }

    [BinaryContent(Name = "Positions", NodeType = BinaryContentTypes.Node)]
    public Positions Positions { get; set; }

    [BinaryContent(Name = "OccupyTimes", NodeType = BinaryContentTypes.Node)]
    public OccupyTimes OccupyTimes { get; set; }

  }
}