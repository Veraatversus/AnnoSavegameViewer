using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildabilityCache {

[BinaryContent(Name = "CachePerIsland", NodeType = BinaryContentTypes.Node)]
public CachePerIsland CachePerIsland { get; set; }

[BinaryContent(Name = "CachePerSession", NodeType = BinaryContentTypes.Node)]
public CachePerSession CachePerSession { get; set; }

[BinaryContent(Name = "RequestsWaitingForNewIsland", NodeType = BinaryContentTypes.Node)]
public RequestsWaitingForNewIsland RequestsWaitingForNewIsland { get; set; }

[BinaryContent(Name = "LastCacheClear", NodeType = BinaryContentTypes.Attribute)]
public HexString LastCacheClear { get; set; }

}
}
