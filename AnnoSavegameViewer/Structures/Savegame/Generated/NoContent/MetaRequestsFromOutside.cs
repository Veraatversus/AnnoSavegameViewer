using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaRequestsFromOutside {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MetaRequestsFromOutsideList> MetaRequestsFromOutsideList { get; set; }

  }
}