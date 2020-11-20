namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Archive {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArchiveList> ArchiveList { get; set; }

  }
}