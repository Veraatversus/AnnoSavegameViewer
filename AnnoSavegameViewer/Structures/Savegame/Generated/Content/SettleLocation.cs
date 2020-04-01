using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SettleLocation {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Stopover", NodeType = BinaryContentTypes.Attribute)]
    public object Stopover { get; set; }

    [BinaryContent(Name = "KontorPos", NodeType = BinaryContentTypes.Attribute)]
    public object KontorPos { get; set; }

    [BinaryContent(Name = "ApproachType", NodeType = BinaryContentTypes.Node)]
    public ApproachType ApproachType { get; set; }

    [BinaryContent(Name = "Coastline", NodeType = BinaryContentTypes.Node)]
    public Coastline Coastline { get; set; }

    [BinaryContent(Name = "RecommendedPos", NodeType = BinaryContentTypes.Node)]
    public RecommendedPos RecommendedPos { get; set; }

  }
}