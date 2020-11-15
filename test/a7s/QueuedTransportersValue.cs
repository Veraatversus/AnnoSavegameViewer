using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class QueuedTransportersValue {

[BinaryContent(Name = "Transporter", NodeType = BinaryContentTypes.Node)]
public Transporter Transporter { get; set; }

[BinaryContent(Name = "ProcessingTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ProcessingTime { get; set; }

[BinaryContent(Name = "ProcessingEndTime", NodeType = BinaryContentTypes.Attribute)]
public HexString ProcessingEndTime { get; set; }

}
}
