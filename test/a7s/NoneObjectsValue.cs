using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneObjectsValue {

[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectID { get; set; }

[BinaryContent(Name = "CargoItems", NodeType = BinaryContentTypes.Node)]
public NoneCargoItems CargoItems { get; set; }

}
}
