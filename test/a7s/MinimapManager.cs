using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MinimapManager {

[BinaryContent(Name = "CityDataSize", NodeType = BinaryContentTypes.Attribute)]
public HexString CityDataSize { get; set; }

[BinaryContent(Name = "CityData", NodeType = BinaryContentTypes.Attribute)]
public HexString CityData { get; set; }

}
}
