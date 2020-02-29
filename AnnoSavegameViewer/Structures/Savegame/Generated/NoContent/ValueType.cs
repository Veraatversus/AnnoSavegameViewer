using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ValueType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ValueTypeValue Value { get; set; }

  }
}