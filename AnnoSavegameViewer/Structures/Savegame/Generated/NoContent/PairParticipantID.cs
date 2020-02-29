using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PairParticipantID {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PairParticipantIDValue Value { get; set; }

  }
}