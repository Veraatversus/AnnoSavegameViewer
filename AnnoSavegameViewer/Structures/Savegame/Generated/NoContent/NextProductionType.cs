using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NextProductionType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public NextProductionTypeValue Value { get; set; }

  }
}