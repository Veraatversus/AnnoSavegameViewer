using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaData {

    [BinaryContent(Name = "QuestArea", NodeType = BinaryContentTypes.Attribute)]
    public object QuestArea { get; set; }

  }
}