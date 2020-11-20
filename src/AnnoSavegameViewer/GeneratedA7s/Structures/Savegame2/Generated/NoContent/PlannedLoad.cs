namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PlannedLoad {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PlannedLoadList> PlannedLoadList { get; set; }

  }
}