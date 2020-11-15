namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ConstructionQueueRequestsList {

    [BinaryContent(Name = "ScndPriority", NodeType = BinaryContentTypes.Attribute)]
    public object ScndPriority { get; set; }

    [BinaryContent(Name = "ForceAreaID", NodeType = BinaryContentTypes.Attribute)]
    public object ForceAreaID { get; set; }

    [BinaryContent(Name = "BestAreaID", NodeType = BinaryContentTypes.Attribute)]
    public object BestAreaID { get; set; }

    [BinaryContent(Name = "BuildingGUID", NodeType = BinaryContentTypes.Attribute)]
    public object BuildingGUID { get; set; }

    [BinaryContent(Name = "CrafterGUID", NodeType = BinaryContentTypes.Attribute)]
    public object CrafterGUID { get; set; }

    [BinaryContent(Name = "RequestType", NodeType = BinaryContentTypes.Node)]
    public RequestType RequestType { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
    public ConstructionQueueRequestsListPriority Priority { get; set; }

    [BinaryContent(Name = "ConstructionRequestSource", NodeType = BinaryContentTypes.Node)]
    public ConstructionRequestSource ConstructionRequestSource { get; set; }

    [BinaryContent(Name = "OriginalRequestSource", NodeType = BinaryContentTypes.Node)]
    public OriginalRequestSource OriginalRequestSource { get; set; }

    [BinaryContent(Name = "Materials", NodeType = BinaryContentTypes.Node)]
    public Materials Materials { get; set; }

    [BinaryContent(Name = "Budget", NodeType = BinaryContentTypes.Node)]
    public Budget Budget { get; set; }
  }
}