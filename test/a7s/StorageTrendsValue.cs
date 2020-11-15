using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StorageTrendsValue {

[BinaryContent(Name = "Points", NodeType = BinaryContentTypes.Node)]
public Points Points { get; set; }

[BinaryContent(Name = "LastPointTime", NodeType = BinaryContentTypes.Attribute)]
public HexString LastPointTime { get; set; }

[BinaryContent(Name = "Estimation", NodeType = BinaryContentTypes.Attribute)]
public HexString Estimation { get; set; }

}
}
