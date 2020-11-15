using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class FineGrid {

[BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
public HexString AreaID { get; set; }

[BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
public HexString Origin { get; set; }

[BinaryContent(Name = "Max", NodeType = BinaryContentTypes.Attribute)]
public HexString Max { get; set; }

[BinaryContent(Name = "Dimensions", NodeType = BinaryContentTypes.Attribute)]
public HexString Dimensions { get; set; }

[BinaryContent(Name = "LandBuildableRect", NodeType = BinaryContentTypes.Attribute)]
public HexString LandBuildableRect { get; set; }

[BinaryContent(Name = "FineGridData", NodeType = BinaryContentTypes.Attribute)]
public HexString FineGridData { get; set; }

}
}
