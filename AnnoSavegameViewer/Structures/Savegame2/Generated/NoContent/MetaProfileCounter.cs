namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MetaProfileCounter {

    [BinaryContent(Name = "Stats", NodeType = BinaryContentTypes.Node)]
    public Stats Stats { get; set; }

  }
}