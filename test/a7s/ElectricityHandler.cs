using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ElectricityHandler {

[BinaryContent(Name = "PowerPlants", NodeType = BinaryContentTypes.Node)]
public PowerPlants PowerPlants { get; set; }

[BinaryContent(Name = "LastRequesterTime", NodeType = BinaryContentTypes.Attribute)]
public HexString LastRequesterTime { get; set; }

[BinaryContent(Name = "LastRequester", NodeType = BinaryContentTypes.Node)]
public LastRequester LastRequester { get; set; }

}
}
