namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SettleParams {

    [BinaryContent(Name = "ForceArea", NodeType = BinaryContentTypes.Attribute)]
    public object ForceArea { get; set; }

    [BinaryContent(Name = "RecommendedPosition", NodeType = BinaryContentTypes.Node)]
    public RecommendedPosition RecommendedPosition { get; set; }

    [BinaryContent(Name = "SettleMissionType", NodeType = BinaryContentTypes.Node)]
    public SettleMissionType SettleMissionType { get; set; }

  }
}