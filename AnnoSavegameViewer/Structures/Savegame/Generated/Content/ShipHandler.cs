namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ShipHandler {

    [BinaryContent(Name = "LastDestroyShipTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastDestroyShipTick { get; set; }

    [BinaryContent(Name = "MetaRequestID", NodeType = BinaryContentTypes.Attribute)]
    public object MetaRequestID { get; set; }

    [BinaryContent(Name = "DestroyedIdleShips", NodeType = BinaryContentTypes.Attribute)]
    public object DestroyedIdleShips { get; set; }

    [BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Node)]
    public Ships Ships { get; set; }

    [BinaryContent(Name = "Requests", NodeType = BinaryContentTypes.Node)]
    public Requests Requests { get; set; }

    [BinaryContent(Name = "CraftableWhitelist", NodeType = BinaryContentTypes.Node)]
    public CraftableWhitelist CraftableWhitelist { get; set; }

    [BinaryContent(Name = "Construction", NodeType = BinaryContentTypes.Node)]
    public Construction Construction { get; set; }

    [BinaryContent(Name = "DestructionNot", NodeType = BinaryContentTypes.Node)]
    public DestructionNot DestructionNot { get; set; }

    [BinaryContent(Name = "LastKilled", NodeType = BinaryContentTypes.Node)]
    public LastKilled LastKilled { get; set; }

    [BinaryContent(Name = "TargetShipWeights", NodeType = BinaryContentTypes.Node)]
    public TargetShipWeights TargetShipWeights { get; set; }

  }
}