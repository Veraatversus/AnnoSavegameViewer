using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class VehicleConstruction {

[BinaryContent(Name = "PendingCraftables", NodeType = BinaryContentTypes.Node)]
public PendingCraftables PendingCraftables { get; set; }

}
}
