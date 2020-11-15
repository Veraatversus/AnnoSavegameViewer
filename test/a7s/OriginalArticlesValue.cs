using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class OriginalArticlesValue {

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Node)]
public Size Size { get; set; }

[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
public NoneContext Context { get; set; }

[BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Attribute)]
public HexString Priority { get; set; }

[BinaryContent(Name = "IsUsedForNewspaper", NodeType = BinaryContentTypes.Attribute)]
public HexString IsUsedForNewspaper { get; set; }

}
}
