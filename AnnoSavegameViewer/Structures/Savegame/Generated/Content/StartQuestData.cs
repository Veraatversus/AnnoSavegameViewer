using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StartQuestData {

    [BinaryContent(Name = "TriggeringChain", NodeType = BinaryContentTypes.Attribute)]
    public object TriggeringChain { get; set; }

    [BinaryContent(Name = "MetaData", NodeType = BinaryContentTypes.Node)]
    public MetaData MetaData { get; set; }

  }
}