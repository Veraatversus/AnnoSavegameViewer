using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LogisticNodeStorageList {

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGUID { get; set; }

    [BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentAmount { get; set; }

    [BinaryContent(Name = "MaxAmount", NodeType = BinaryContentTypes.Attribute)]
    public object MaxAmount { get; set; }

    [BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
    public LogisticNodeStorageListReservedAmount ReservedAmount { get; set; }

    [BinaryContent(Name = "ReservedSpace", NodeType = BinaryContentTypes.Node)]
    public LogisticNodeStorageListReservedSpace ReservedSpace { get; set; }

  }
}