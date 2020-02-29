using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RunningQuestsListQuestMetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

  }
}