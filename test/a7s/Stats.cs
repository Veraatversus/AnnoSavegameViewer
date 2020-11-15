using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Stats {

[BinaryContent(Name = "AreaCounter", NodeType = BinaryContentTypes.Node)]
public StatsAreaCounter AreaCounter { get; set; }

[BinaryContent(Name = "SessionCounter", NodeType = BinaryContentTypes.Node)]
public SessionCounter SessionCounter { get; set; }

[BinaryContent(Name = "RegionCounter", NodeType = BinaryContentTypes.Node)]
public RegionCounter RegionCounter { get; set; }

[BinaryContent(Name = "GlobalCounter", NodeType = BinaryContentTypes.Node)]
public StatsGlobalCounter GlobalCounter { get; set; }

}
}
