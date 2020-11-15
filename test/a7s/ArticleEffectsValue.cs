using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ArticleEffectsValue {

[BinaryContent(Name = "Effect", NodeType = BinaryContentTypes.Node)]
public Effect Effect { get; set; }

[BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
public HexString Value { get; set; }

[BinaryContent(Name = "TriggeredByPropaganda", NodeType = BinaryContentTypes.Attribute)]
public HexString TriggeredByPropaganda { get; set; }

[BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
public HexString Context { get; set; }

}
}
