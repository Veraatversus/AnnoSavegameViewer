namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ArchiveListList {

    #region Public Properties

    [BinaryContent(Name = "TitleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TitleGUID { get; set; }

    [BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TextGUID { get; set; }

    [BinaryContent(Name = "IconGUID", NodeType = BinaryContentTypes.Attribute)]
    public object IconGUID { get; set; }

    [BinaryContent(Name = "SubtitleGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SubtitleGUID { get; set; }

    [BinaryContent(Name = "Infotip", NodeType = BinaryContentTypes.Attribute)]
    public object Infotip { get; set; }

    [BinaryContent(Name = "IsWarning", NodeType = BinaryContentTypes.Attribute)]
    public object IsWarning { get; set; }

    [BinaryContent(Name = "IsRead", NodeType = BinaryContentTypes.Attribute)]
    public object IsRead { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "SoundGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SoundGUID { get; set; }

    [BinaryContent(Name = "MinDisplayTime", NodeType = BinaryContentTypes.Attribute)]
    public object MinDisplayTime { get; set; }

    [BinaryContent(Name = "DisplayTimeout", NodeType = BinaryContentTypes.Attribute)]
    public object DisplayTimeout { get; set; }

    [BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object SessionGUID { get; set; }

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
    public object Priority { get; set; }

    [BinaryContent(Name = "RestrictedToSessionOrRegions", NodeType = BinaryContentTypes.Attribute)]
    public object RestrictedToSessionOrRegions { get; set; }

    [BinaryContent(Name = "EnqueueTime", NodeType = BinaryContentTypes.Attribute)]
    public object EnqueueTime { get; set; }

    [BinaryContent(Name = "TimeInPause", NodeType = BinaryContentTypes.Attribute)]
    public object TimeInPause { get; set; }

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "PositionSessionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object PositionSessionGUID { get; set; }

    [BinaryContent(Name = "hasInteraction", NodeType = BinaryContentTypes.Attribute)]
    public object HasInteraction { get; set; }

    [BinaryContent(Name = "JumpLocation", NodeType = BinaryContentTypes.Attribute)]
    public object JumpLocation { get; set; }

    [BinaryContent(Name = "Category", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListCategory Category { get; set; }

    [BinaryContent(Name = "StringReplacements", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListStringReplacements StringReplacements { get; set; }

    [BinaryContent(Name = "TextInfo", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListTextInfo TextInfo { get; set; }

    [BinaryContent(Name = "FilterType", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListFilterType FilterType { get; set; }

    [BinaryContent(Name = "Group", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListGroup Group { get; set; }

    [BinaryContent(Name = "TargetPeer", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListTargetPeer TargetPeer { get; set; }

    [BinaryContent(Name = "StartTime", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListStartTime StartTime { get; set; }

    [BinaryContent(Name = "EndTime", NodeType = BinaryContentTypes.Node)]
    public ArchiveListListEndTime EndTime { get; set; }

    [BinaryContent(Name = "Interaction", NodeType = BinaryContentTypes.Node)]
    public Interaction Interaction { get; set; }

    #endregion Public Properties
  }
}