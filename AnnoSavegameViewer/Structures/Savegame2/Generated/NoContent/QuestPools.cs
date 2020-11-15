namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class QuestPools {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QuestPoolsList> QuestPoolsList { get; set; }

  }
}