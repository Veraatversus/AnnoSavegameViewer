using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiscoveryParticipantsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DiscoveryParticipantsListValue Value { get; set; }

  }
}