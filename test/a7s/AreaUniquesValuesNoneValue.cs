using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaUniquesValuesNoneValue {

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

[BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
public NoneValuesNoneType Type { get; set; }

[BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectID { get; set; }

}
}
