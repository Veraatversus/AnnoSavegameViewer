using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ParticipantRelation {

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public ParticipantRelationSource Source { get; set; }

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
    public ParticipantRelationTarget Target { get; set; }

  }
}