using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ObjectGroupCollectionObjectGroupsList {

    [BinaryContent(Name = "GameObjects", NodeType = BinaryContentTypes.Node)]
    public GameObjects GameObjects { get; set; }

  }
}