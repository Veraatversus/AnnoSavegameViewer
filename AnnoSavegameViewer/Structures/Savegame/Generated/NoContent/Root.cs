using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Root {

    [BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
    public Filter Filter { get; set; }

  }
}