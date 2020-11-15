using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Element {

[BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
public HexString Data { get; set; }

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
public HexString Time { get; set; }

[BinaryContent(Name = "Delta", NodeType = BinaryContentTypes.Attribute)]
public HexString Delta { get; set; }

}
}
