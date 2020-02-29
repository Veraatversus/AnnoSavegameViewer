using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StoredSelectionsListList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StoredSelectionsListListList> StoredSelectionsListListList { get; set; }

  }
}