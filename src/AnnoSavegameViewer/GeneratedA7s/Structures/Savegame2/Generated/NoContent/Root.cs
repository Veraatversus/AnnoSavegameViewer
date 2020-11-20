namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Root {

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public Filter Filter { get; set; }

  }
}