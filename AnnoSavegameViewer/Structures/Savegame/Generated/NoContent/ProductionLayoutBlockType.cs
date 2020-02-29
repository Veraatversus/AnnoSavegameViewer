using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductionLayoutBlockType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ProductionLayoutBlockTypeValue Value { get; set; }

  }
}