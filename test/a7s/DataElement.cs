using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DataElement {

[BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
public HexString Data { get; set; }

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
public HexString Time { get; set; }

}
}
