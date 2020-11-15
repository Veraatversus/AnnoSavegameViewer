using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaUniqueBuildingHandler {

[BinaryContent(Name = "AreaUniques", NodeType = BinaryContentTypes.Node)]
public AreaUniques AreaUniques { get; set; }

[BinaryContent(Name = "SessionUniques", NodeType = BinaryContentTypes.Node)]
public SessionUniques SessionUniques { get; set; }

[BinaryContent(Name = "GameUniques", NodeType = BinaryContentTypes.Node)]
public GameUniques GameUniques { get; set; }

}
}
