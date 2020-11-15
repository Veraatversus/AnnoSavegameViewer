namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CitySize {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CitySizeValue Value { get; set; }

  }
}