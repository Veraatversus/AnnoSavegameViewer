using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ItemReference {

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

}
}
