using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ConsumptionStatesValue {

[BinaryContent(Name = "CurrentSaturation", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentSaturation { get; set; }

[BinaryContent(Name = "AverageSaturation", NodeType = BinaryContentTypes.Attribute)]
public HexString AverageSaturation { get; set; }

}
}
