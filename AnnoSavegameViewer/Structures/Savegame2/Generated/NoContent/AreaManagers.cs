namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaManagers {

    [BinaryContent(Name = "AreaManager", NodeType = BinaryContentTypes.Node)]
    public List<AreaManager> AreaManager { get; set; }

  }
}