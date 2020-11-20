namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ActiveType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveTypeValue Value { get; set; }

  }
}