namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AttackerDataList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AttackerDataListList> AttackerDataListList { get; set; }

  }
}