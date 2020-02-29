using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ArchiveList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArchiveListList> ArchiveListList { get; set; }

  }
}