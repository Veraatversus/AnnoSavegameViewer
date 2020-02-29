using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentPosition {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentPositionValue Value { get; set; }

  }
}