using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildabilityCache {

    [BinaryContent(Name = "LastCacheClear", NodeType = BinaryContentTypes.Attribute)]
    public object LastCacheClear { get; set; }

    [BinaryContent(Name = "CachePerIsland", NodeType = BinaryContentTypes.Node)]
    public CachePerIsland CachePerIsland { get; set; }

    [BinaryContent(Name = "CachePerSession", NodeType = BinaryContentTypes.Node)]
    public CachePerSession CachePerSession { get; set; }

    [BinaryContent(Name = "RequestsWaitingForNewIsland", NodeType = BinaryContentTypes.Node)]
    public RequestsWaitingForNewIsland RequestsWaitingForNewIsland { get; set; }

  }
}