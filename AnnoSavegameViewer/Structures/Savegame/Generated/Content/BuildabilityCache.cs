namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BuildabilityCache {

    #region Public Properties

    [BinaryContent(Name = "LastCacheClear", NodeType = BinaryContentTypes.Attribute)]
    public object LastCacheClear { get; set; }

    [BinaryContent(Name = "CachePerIsland", NodeType = BinaryContentTypes.Node)]
    public CachePerIsland CachePerIsland { get; set; }

    [BinaryContent(Name = "CachePerSession", NodeType = BinaryContentTypes.Node)]
    public CachePerSession CachePerSession { get; set; }

    [BinaryContent(Name = "RequestsWaitingForNewIsland", NodeType = BinaryContentTypes.Node)]
    public RequestsWaitingForNewIsland RequestsWaitingForNewIsland { get; set; }

    #endregion Public Properties
  }
}