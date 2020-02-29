using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Archive {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ArchiveList> ArchiveList { get; set; }

  }
}