using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaUniquesListList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public AreaUniquesListListType Type { get; set; }

  }
}