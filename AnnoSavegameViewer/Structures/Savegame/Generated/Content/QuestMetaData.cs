using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestMetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

  }
}