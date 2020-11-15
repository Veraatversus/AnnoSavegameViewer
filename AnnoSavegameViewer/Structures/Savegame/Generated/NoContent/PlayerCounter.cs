namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PlayerCounter {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public Value Value { get; set; }

  }
}