namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OfferMapList {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "TargetAmount", NodeType = BinaryContentTypes.Attribute)]
    public object TargetAmount { get; set; }

    [BinaryContent(Name = "GoodGuid", NodeType = BinaryContentTypes.Attribute)]
    public object GoodGuid { get; set; }

    [BinaryContent(Name = "IsDirty", NodeType = BinaryContentTypes.Attribute)]
    public object IsDirty { get; set; }

    [BinaryContent(Name = "IsPreferedGood", NodeType = BinaryContentTypes.Attribute)]
    public object IsPreferedGood { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public OfferMapListType Type { get; set; }

  }
}