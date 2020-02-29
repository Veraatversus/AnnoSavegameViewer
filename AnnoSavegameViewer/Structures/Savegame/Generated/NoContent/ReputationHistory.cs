using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReputationHistory {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ReputationHistoryList> ReputationHistoryList { get; set; }

  }
}