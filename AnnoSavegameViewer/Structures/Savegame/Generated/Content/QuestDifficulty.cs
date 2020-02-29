using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestDifficulty {

    [BinaryContent(Name = "QuestDifficulty", NodeType = BinaryContentTypes.Attribute)]
    public object QuestDifficultyItem { get; set; }

  }
}