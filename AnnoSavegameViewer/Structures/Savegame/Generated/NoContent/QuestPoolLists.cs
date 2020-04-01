using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestPoolLists {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public QuestPoolListsData Data { get; set; }

  }
}