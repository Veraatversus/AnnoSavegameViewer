namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DiscoveredParticipants {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiscoveredParticipantsList> DiscoveredParticipantsList { get; set; }

  }
}