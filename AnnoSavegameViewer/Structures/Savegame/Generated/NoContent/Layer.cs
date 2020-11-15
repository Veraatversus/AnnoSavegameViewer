namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Layer {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LayerValue Value { get; set; }

  }
}