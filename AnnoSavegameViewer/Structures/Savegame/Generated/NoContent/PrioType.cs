using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PrioType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PrioTypeValue Value { get; set; }

  }
}