using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ModuleOwner {

[BinaryContent(Name = "BuildingModules", NodeType = BinaryContentTypes.Attribute)]
public HexString BuildingModules { get; set; }

[BinaryContent(Name = "AdditionalModule", NodeType = BinaryContentTypes.Node)]
public AdditionalModule AdditionalModule { get; set; }

[BinaryContent(Name = "SlotIndexGenerator", NodeType = BinaryContentTypes.Attribute)]
public HexString SlotIndexGenerator { get; set; }

}
}
