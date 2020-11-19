namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ArchiveList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArchiveListList> ArchiveListList { get; set; }

  }
}