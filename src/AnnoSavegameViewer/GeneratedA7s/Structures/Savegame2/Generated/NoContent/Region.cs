namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Region {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RegionValue Value { get; set; }

  }
}