using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Decree {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public DecreeValue Value { get; set; }

}
}
