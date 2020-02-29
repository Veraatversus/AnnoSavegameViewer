using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CityLayoutBlockType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CityLayoutBlockTypeValue Value { get; set; }

  }
}