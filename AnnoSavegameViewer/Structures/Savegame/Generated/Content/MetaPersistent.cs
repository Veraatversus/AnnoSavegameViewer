using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaPersistent {

    [BinaryContent(Name = "MetaID", NodeType = BinaryContentTypes.Attribute)]
    public object MetaID { get; set; }

  }
}