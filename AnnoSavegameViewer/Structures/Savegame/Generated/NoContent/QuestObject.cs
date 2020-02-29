using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QuestObject {

    [BinaryContent(Name = "QuestIDs", NodeType = BinaryContentTypes.Node)]
    public QuestIDs QuestIDs { get; set; }

    [BinaryContent(Name = "ObjectWasVisible", NodeType = BinaryContentTypes.Node)]
    public ObjectWasVisible ObjectWasVisible { get; set; }

    [BinaryContent(Name = "OverwriteVisualParticipant", NodeType = BinaryContentTypes.Node)]
    public OverwriteVisualParticipant OverwriteVisualParticipant { get; set; }

  }
}