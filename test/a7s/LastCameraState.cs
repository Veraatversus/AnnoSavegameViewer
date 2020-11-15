using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LastCameraState {

[BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
public View View { get; set; }

[BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
public Projection Projection { get; set; }

[BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
public HexString PresetId { get; set; }

[BinaryContent(Name = "CameraPeer", NodeType = BinaryContentTypes.Node)]
public CameraPeer CameraPeer { get; set; }

[BinaryContent(Name = "SyncedStatesArray", NodeType = BinaryContentTypes.Node)]
public SyncedStatesArray SyncedStatesArray { get; set; }

[BinaryContent(Name = "CurZoomPreset", NodeType = BinaryContentTypes.Attribute)]
public HexString CurZoomPreset { get; set; }

}
}
