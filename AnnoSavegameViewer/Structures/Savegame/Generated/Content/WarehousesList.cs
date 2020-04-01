using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class WarehousesList {

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "RectWS", NodeType = BinaryContentTypes.Attribute)]
    public object RectWS { get; set; }

  }
}