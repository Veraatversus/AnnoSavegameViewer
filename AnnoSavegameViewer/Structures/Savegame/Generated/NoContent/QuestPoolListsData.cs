using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestPoolListsData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QuestPoolListsDataList> QuestPoolListsDataList { get; set; }

  }
}