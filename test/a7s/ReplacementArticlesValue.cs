using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ReplacementArticlesValue {

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Node)]
public NoneSize Size { get; set; }

[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Node)]
public ValuesNoneContext Context { get; set; }

[BinaryContent(Name = "IsUsedForNewspaper", NodeType = BinaryContentTypes.Attribute)]
public HexString IsUsedForNewspaper { get; set; }

}
}
