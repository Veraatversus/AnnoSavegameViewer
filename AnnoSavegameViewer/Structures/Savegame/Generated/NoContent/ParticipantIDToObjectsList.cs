using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantIDToObjectsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ParticipantIDToObjectsListValue Value { get; set; }

  }
}