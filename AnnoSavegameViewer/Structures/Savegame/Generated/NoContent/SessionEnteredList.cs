using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionEnteredList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SessionEnteredListValue Value { get; set; }

  }
}