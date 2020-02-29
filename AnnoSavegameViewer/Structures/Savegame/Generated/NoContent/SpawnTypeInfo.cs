using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpawnTypeInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public SpawnTypeInfoList SpawnTypeInfoList { get; set; }

  }
}