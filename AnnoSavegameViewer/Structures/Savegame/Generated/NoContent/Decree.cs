namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Decree {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DecreeValue Value { get; set; }

  }
}