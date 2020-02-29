using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CitySize {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CitySizeValue Value { get; set; }

  }
}