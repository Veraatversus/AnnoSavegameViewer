namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Target {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetValue Value { get; set; }

  }
}