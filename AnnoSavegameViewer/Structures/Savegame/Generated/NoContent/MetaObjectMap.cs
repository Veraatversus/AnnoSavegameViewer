using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaObjectMap {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MetaObjectMapList> MetaObjectMapList { get; set; }

  }
}