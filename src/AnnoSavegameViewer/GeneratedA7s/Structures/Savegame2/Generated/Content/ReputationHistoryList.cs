namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ReputationHistoryList {

    [BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TextGUID { get; set; }

    [BinaryContent(Name = "ReputationChange", NodeType = BinaryContentTypes.Attribute)]
    public object ReputationChange { get; set; }

  }
}