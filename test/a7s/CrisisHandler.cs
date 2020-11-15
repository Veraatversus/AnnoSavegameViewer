using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CrisisHandler {

[BinaryContent(Name = "Crises", NodeType = BinaryContentTypes.Node)]
public Crises Crises { get; set; }

[BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
public HexString LastTick { get; set; }

}
}
