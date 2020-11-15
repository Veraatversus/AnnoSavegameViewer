using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaTriggeredValue {

[BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
public HexString Area { get; set; }

[BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
public HexString GUID { get; set; }

}
}
