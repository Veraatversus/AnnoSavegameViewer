using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OriginalShareOwner {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OriginalShareOwnerList> OriginalShareOwnerList { get; set; }

  }
}