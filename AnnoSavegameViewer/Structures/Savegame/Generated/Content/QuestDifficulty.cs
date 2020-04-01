using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestDifficulty {

    [BinaryContent(Name = "QuestDifficulty", NodeType = BinaryContentTypes.Attribute)]
    public object QuestDifficultyItem { get; set; }

  }
}