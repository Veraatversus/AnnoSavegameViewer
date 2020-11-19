namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ReputationHistory {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ReputationHistoryList> ReputationHistoryList { get; set; }

  }
}