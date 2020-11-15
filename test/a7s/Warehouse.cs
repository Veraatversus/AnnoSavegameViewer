using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Warehouse {

[BinaryContent(Name = "StorageCapacityRegistered", NodeType = BinaryContentTypes.Attribute)]
public HexString StorageCapacityRegistered { get; set; }

[BinaryContent(Name = "LockedStorage", NodeType = BinaryContentTypes.Node)]
public LockedStorage LockedStorage { get; set; }

}
}
