namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class QuestPoolListsData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QuestPoolListsDataList> QuestPoolListsDataList { get; set; }

  }
}