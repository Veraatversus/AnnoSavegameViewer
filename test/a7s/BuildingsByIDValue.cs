using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildingsByIDValue {

[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectID { get; set; }

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "CenterPos", NodeType = BinaryContentTypes.Attribute)]
public HexString CenterPos { get; set; }

[BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
public HexString Rotation { get; set; }

[BinaryContent(Name = "Variation", NodeType = BinaryContentTypes.Attribute)]
public HexString Variation { get; set; }

}
}
