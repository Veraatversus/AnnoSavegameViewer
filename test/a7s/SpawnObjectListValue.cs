using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SpawnObjectListValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
public HexString Amount { get; set; }

[BinaryContent(Name = "CargoGUIDList", NodeType = BinaryContentTypes.Node)]
public ValuesNoneCargoGUIDList CargoGUIDList { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public SpawnObjectListValuesNoneOwner Owner { get; set; }

[BinaryContent(Name = "VisualOwner", NodeType = BinaryContentTypes.Node)]
public ValuesNoneVisualOwner VisualOwner { get; set; }

}
}
