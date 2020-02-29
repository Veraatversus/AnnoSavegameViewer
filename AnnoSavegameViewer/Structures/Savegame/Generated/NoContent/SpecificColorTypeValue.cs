using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpecificColorTypeValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SpecificColorTypeValueValue Value { get; set; }

  }
}