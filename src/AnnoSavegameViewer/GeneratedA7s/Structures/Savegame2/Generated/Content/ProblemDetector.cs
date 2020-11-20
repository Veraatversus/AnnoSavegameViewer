namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ProblemDetector {

    [BinaryContent(Name = "LastTradeShipCount", NodeType = BinaryContentTypes.Attribute)]
    public object LastTradeShipCount { get; set; }

    [BinaryContent(Name = "LastShipProgress", NodeType = BinaryContentTypes.Attribute)]
    public object LastShipProgress { get; set; }

    [BinaryContent(Name = "LastBuildingProgress", NodeType = BinaryContentTypes.Attribute)]
    public object LastBuildingProgress { get; set; }

    [BinaryContent(Name = "LastCheck", NodeType = BinaryContentTypes.Attribute)]
    public object LastCheck { get; set; }

    [BinaryContent(Name = "LastCleanupTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastCleanupTick { get; set; }

    [BinaryContent(Name = "LastForceRemove", NodeType = BinaryContentTypes.Attribute)]
    public object LastForceRemove { get; set; }

    [BinaryContent(Name = "ShipSolveCount", NodeType = BinaryContentTypes.Attribute)]
    public object ShipSolveCount { get; set; }

    [BinaryContent(Name = "ForceReconstruct", NodeType = BinaryContentTypes.Attribute)]
    public object ForceReconstruct { get; set; }

    [BinaryContent(Name = "CountsPerGUID", NodeType = BinaryContentTypes.Node)]
    public CountsPerGUID CountsPerGUID { get; set; }

    [BinaryContent(Name = "BuildingSolves", NodeType = BinaryContentTypes.Node)]
    public BuildingSolves BuildingSolves { get; set; }

  }
}