using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DestroySpawnInfoValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

[BinaryContent(Name = "CargoGUIDList", NodeType = BinaryContentTypes.Node)]
public CargoGUIDList CargoGUIDList { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public DestroySpawnInfoValuesNoneOwner Owner { get; set; }

[BinaryContent(Name = "VisualOwner", NodeType = BinaryContentTypes.Node)]
public VisualOwner VisualOwner { get; set; }

}
}
