using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestPools {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<QuestPoolsList> QuestPoolsList { get; set; }

  }
}