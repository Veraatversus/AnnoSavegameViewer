namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CivLevelInfos {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CivLevelInfosList> CivLevelInfosList { get; set; }

  }
}