using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OfferedItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OfferedItemsList> OfferedItemsList { get; set; }

  }
}