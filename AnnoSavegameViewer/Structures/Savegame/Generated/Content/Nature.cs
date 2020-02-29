using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Nature {

    [BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
    public NatureObjects Objects { get; set; }

  }
}