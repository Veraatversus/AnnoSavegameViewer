using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ValuesNoneFilterValue {

[BinaryContent(Name = "FolderID", NodeType = BinaryContentTypes.Attribute)]
public HexString FolderID { get; set; }

[BinaryContent(Name = "Filter", NodeType = BinaryContentTypes.Node)]
public FilterValuesNoneFilter Filter { get; set; }

}
}
