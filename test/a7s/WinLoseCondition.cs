using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WinLoseCondition {

[BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Node)]
public ElementType ElementType { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public Owner Owner { get; set; }

}
}
