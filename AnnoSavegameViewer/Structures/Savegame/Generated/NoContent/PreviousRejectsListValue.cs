using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PreviousRejectsListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PreviousRejectsListValueValue Value { get; set; }

  }
}