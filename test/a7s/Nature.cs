using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Nature {

[BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
public NatureObjects Objects { get; set; }

}
}
