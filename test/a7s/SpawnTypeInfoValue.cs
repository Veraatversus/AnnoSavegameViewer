using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SpawnTypeInfoValue {

[BinaryContent(Name = "SpawnObjectCount", NodeType = BinaryContentTypes.Attribute)]
public HexString SpawnObjectCount { get; set; }

[BinaryContent(Name = "SpawnedObjectIDs", NodeType = BinaryContentTypes.Attribute)]
public HexString SpawnedObjectIDs { get; set; }

}
}
