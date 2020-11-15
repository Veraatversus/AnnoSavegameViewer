using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneShipsValue {

[BinaryContent(Name = "ShipObject", NodeType = BinaryContentTypes.Attribute)]
public HexString ShipObject { get; set; }

[BinaryContent(Name = "CurrentArea", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentArea { get; set; }

[BinaryContent(Name = "DestinationArea", NodeType = BinaryContentTypes.Attribute)]
public HexString DestinationArea { get; set; }

[BinaryContent(Name = "ShipState", NodeType = BinaryContentTypes.Node)]
public ShipState ShipState { get; set; }

[BinaryContent(Name = "Route", NodeType = BinaryContentTypes.Attribute)]
public HexString Route { get; set; }

}
}
