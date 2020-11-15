using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Nameable {

[BinaryContent(Name = "VehicleName", NodeType = BinaryContentTypes.Attribute)]
public HexString VehicleName { get; set; }

[BinaryContent(Name = "VehicleTextGuid", NodeType = BinaryContentTypes.Attribute)]
public HexString VehicleTextGuid { get; set; }

[BinaryContent(Name = "VehicleTextIterator", NodeType = BinaryContentTypes.Attribute)]
public HexString VehicleTextIterator { get; set; }

}
}
