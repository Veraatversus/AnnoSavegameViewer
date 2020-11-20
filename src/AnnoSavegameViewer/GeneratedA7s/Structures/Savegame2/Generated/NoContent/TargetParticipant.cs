namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TargetParticipant {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetParticipantValue Value { get; set; }

  }
}