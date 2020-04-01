using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GoodInfosList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "StationID", NodeType = BinaryContentTypes.Attribute)]
    public object StationID { get; set; }

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGUID { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "IsLoading", NodeType = BinaryContentTypes.Attribute)]
    public object IsLoading { get; set; }

  }
}