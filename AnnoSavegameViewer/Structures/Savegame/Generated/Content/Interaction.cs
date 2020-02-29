using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Interaction {

    [BinaryContent(Name = "Callback", NodeType = BinaryContentTypes.Attribute)]
    public object Callback { get; set; }

  }
}