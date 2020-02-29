using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiscoveredParticipantsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DiscoveredParticipantsListValue Value { get; set; }

  }
}