using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ExpeditionsList {

    [BinaryContent(Name = "guid", NodeType = BinaryContentTypes.Attribute)]
    public object Guid { get; set; }

    [BinaryContent(Name = "permission", NodeType = BinaryContentTypes.Attribute)]
    public object Permission { get; set; }

    [BinaryContent(Name = "expeditionShip", NodeType = BinaryContentTypes.Attribute)]
    public object ExpeditionShip { get; set; }

    [BinaryContent(Name = "events", NodeType = BinaryContentTypes.Attribute)]
    public object Events { get; set; }

    [BinaryContent(Name = "threats", NodeType = BinaryContentTypes.Attribute)]
    public object Threats { get; set; }

    [BinaryContent(Name = "threatDescriptions", NodeType = BinaryContentTypes.Attribute)]
    public object ThreatDescriptions { get; set; }

    [BinaryContent(Name = "startTimeStamp", NodeType = BinaryContentTypes.Attribute)]
    public object StartTimeStamp { get; set; }

    [BinaryContent(Name = "visitedMapOptions", NodeType = BinaryContentTypes.Attribute)]
    public object VisitedMapOptions { get; set; }

    [BinaryContent(Name = "returnToKontor", NodeType = BinaryContentTypes.Attribute)]
    public object ReturnToKontor { get; set; }

    [BinaryContent(Name = "worldMapAssetCreated", NodeType = BinaryContentTypes.Attribute)]
    public object WorldMapAssetCreated { get; set; }

    [BinaryContent(Name = "owner", NodeType = BinaryContentTypes.Node)]
    public Owner Owner { get; set; }

    [BinaryContent(Name = "state", NodeType = BinaryContentTypes.Node)]
    public ExpeditionsListState State { get; set; }

    [BinaryContent(Name = "threatWeight", NodeType = BinaryContentTypes.Node)]
    public ThreatWeight ThreatWeight { get; set; }

    [BinaryContent(Name = "lastNegativeOutcomeLosses", NodeType = BinaryContentTypes.Node)]
    public LastNegativeOutcomeLosses LastNegativeOutcomeLosses { get; set; }

    [BinaryContent(Name = "lastRewardContainer", NodeType = BinaryContentTypes.Node)]
    public LastRewardContainer LastRewardContainer { get; set; }

    [BinaryContent(Name = "lastRewardResources", NodeType = BinaryContentTypes.Node)]
    public LastRewardResources LastRewardResources { get; set; }

    [BinaryContent(Name = "lastRewardPermits", NodeType = BinaryContentTypes.Node)]
    public LastRewardPermits LastRewardPermits { get; set; }

    [BinaryContent(Name = "feedOptionFactors", NodeType = BinaryContentTypes.Node)]
    public FeedOptionFactors FeedOptionFactors { get; set; }

    [BinaryContent(Name = "preparation", NodeType = BinaryContentTypes.Node)]
    public Preparation Preparation { get; set; }

  }
}