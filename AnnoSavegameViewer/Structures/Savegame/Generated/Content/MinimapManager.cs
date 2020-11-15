namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MinimapManager {

    [BinaryContent(Name = "CityDataSize", NodeType = BinaryContentTypes.Attribute)]
    public object CityDataSize { get; set; }

    [BinaryContent(Name = "CityData", NodeType = BinaryContentTypes.Attribute)]
    public object CityData { get; set; }

  }
}