using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Target {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetValue Value { get; set; }

  }
}