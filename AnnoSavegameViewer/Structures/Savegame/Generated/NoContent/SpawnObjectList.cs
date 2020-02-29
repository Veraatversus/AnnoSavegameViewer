using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnObjectList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public SpawnObjectListList SpawnObjectListList { get; set; }

  }
}