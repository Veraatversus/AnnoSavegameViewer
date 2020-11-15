namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DiscoveryParticipants {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiscoveryParticipantsList> DiscoveryParticipantsList { get; set; }

  }
}