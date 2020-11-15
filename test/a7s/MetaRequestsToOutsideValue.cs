using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaRequestsToOutsideValue {

[BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
public HexString Product { get; set; }

[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
public MetaRequestsToOutsideValuesNonePriority Priority { get; set; }

[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
public MetaRequestsToOutsideValuesNoneSource Source { get; set; }

}
}
