using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GameObject {

    [BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
    public GameObjectObjects Objects { get; set; }

  }
}