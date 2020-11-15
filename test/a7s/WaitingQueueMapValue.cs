using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WaitingQueueMapValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public WaitingQueueMapValuesNoneValue Value { get; set; }

[BinaryContent(Name = "Layer", NodeType = BinaryContentTypes.Node)]
public Layer Layer { get; set; }

[BinaryContent(Name = "QueueEntryList", NodeType = BinaryContentTypes.Node)]
public QueueEntryList QueueEntryList { get; set; }

[BinaryContent(Name = "EllipsisDimensions", NodeType = BinaryContentTypes.Attribute)]
public HexString EllipsisDimensions { get; set; }

[BinaryContent(Name = "WaitingRowArray", NodeType = BinaryContentTypes.Node)]
public WaitingRowArray WaitingRowArray { get; set; }

}
}
