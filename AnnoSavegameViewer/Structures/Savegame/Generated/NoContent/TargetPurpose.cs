using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TargetPurpose {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetPurposeValue Value { get; set; }

  }
}