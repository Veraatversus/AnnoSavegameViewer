namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SpawnDescription {

    [BinaryContent(Name = "AreaType", NodeType = BinaryContentTypes.Attribute)]
    public object AreaType { get; set; }

    [BinaryContent(Name = "SpawnAmount", NodeType = BinaryContentTypes.Attribute)]
    public object SpawnAmount { get; set; }

    [BinaryContent(Name = "ContextObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ContextObjectID { get; set; }

    [BinaryContent(Name = "ContextPosition", NodeType = BinaryContentTypes.Attribute)]
    public object ContextPosition { get; set; }

    [BinaryContent(Name = "DistanceToBorder", NodeType = BinaryContentTypes.Attribute)]
    public object DistanceToBorder { get; set; }

    [BinaryContent(Name = "DistanceToIsland", NodeType = BinaryContentTypes.Attribute)]
    public object DistanceToIsland { get; set; }

    [BinaryContent(Name = "SpreadObject", NodeType = BinaryContentTypes.Attribute)]
    public object SpreadObject { get; set; }

    [BinaryContent(Name = "ContextObjectLabel", NodeType = BinaryContentTypes.Attribute)]
    public object ContextObjectLabel { get; set; }

    [BinaryContent(Name = "DistanceToContext", NodeType = BinaryContentTypes.Attribute)]
    public object DistanceToContext { get; set; }

    [BinaryContent(Name = "MinObjectDistance", NodeType = BinaryContentTypes.Attribute)]
    public object MinObjectDistance { get; set; }

    [BinaryContent(Name = "MaxObjectDistance", NodeType = BinaryContentTypes.Attribute)]
    public object MaxObjectDistance { get; set; }

    [BinaryContent(Name = "ContextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ContextGUID { get; set; }

    [BinaryContent(Name = "ContextMarkerLabel", NodeType = BinaryContentTypes.Attribute)]
    public object ContextMarkerLabel { get; set; }

    [BinaryContent(Name = "LimitToQuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object LimitToQuestArea { get; set; }

    [BinaryContent(Name = "SpawnContextType", NodeType = BinaryContentTypes.Node)]
    public SpawnContextType SpawnContextType { get; set; }

    [BinaryContent(Name = "ParticipantIDClient", NodeType = BinaryContentTypes.Node)]
    public ParticipantIDClient ParticipantIDClient { get; set; }

    [BinaryContent(Name = "ParticipantIDPlayer", NodeType = BinaryContentTypes.Node)]
    public ParticipantIDPlayer ParticipantIDPlayer { get; set; }

  }
}