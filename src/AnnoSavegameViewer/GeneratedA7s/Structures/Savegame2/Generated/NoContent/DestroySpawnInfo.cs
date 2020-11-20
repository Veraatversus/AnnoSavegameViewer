namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DestroySpawnInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DestroySpawnInfoList> DestroySpawnInfoList { get; set; }

  }
}