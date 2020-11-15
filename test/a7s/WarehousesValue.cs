using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WarehousesValue {

[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectID { get; set; }

[BinaryContent(Name = "RectWS", NodeType = BinaryContentTypes.Attribute)]
public HexString RectWS { get; set; }

}
}
