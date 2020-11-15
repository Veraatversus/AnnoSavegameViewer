namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SpawnObjectList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SpawnObjectListList> SpawnObjectListList { get; set; }

  }
}