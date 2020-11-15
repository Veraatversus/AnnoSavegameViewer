using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UserSavedCameraStatesValue {

[BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
public NoneView View { get; set; }

[BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
public NoneProjection Projection { get; set; }

[BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
public HexString PresetId { get; set; }

}
}
