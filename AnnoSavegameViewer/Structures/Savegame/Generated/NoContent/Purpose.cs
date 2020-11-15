namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Purpose {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PurposeValue Value { get; set; }

  }
}