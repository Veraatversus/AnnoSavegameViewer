using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CommandGroupInformation {

[BinaryContent(Name = "OverwriteSetitng", NodeType = BinaryContentTypes.Node)]
public OverwriteSetitng OverwriteSetitng { get; set; }

[BinaryContent(Name = "GroupInformation", NodeType = BinaryContentTypes.Node)]
public GroupInformation GroupInformation { get; set; }

}
}
