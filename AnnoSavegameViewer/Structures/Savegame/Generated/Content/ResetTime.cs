using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResetTime {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

  }
}