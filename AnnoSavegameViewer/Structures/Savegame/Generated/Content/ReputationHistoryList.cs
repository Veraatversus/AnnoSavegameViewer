using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReputationHistoryList {

    [BinaryContent(Name = "TextGUID", NodeType = BinaryContentTypes.Attribute)]
    public object TextGUID { get; set; }

    [BinaryContent(Name = "ReputationChange", NodeType = BinaryContentTypes.Attribute)]
    public object ReputationChange { get; set; }

  }
}