namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class LastCameraState {

    [BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
    public List<object> PresetId { get; set; }

    [BinaryContent(Name = "CurZoomPreset", NodeType = BinaryContentTypes.Attribute)]
    public object CurZoomPreset { get; set; }

    [BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
    public List<LastCameraStateView> View { get; set; }

    [BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
    public List<LastCameraStateProjection> Projection { get; set; }

    [BinaryContent(Name = "CameraPeer", NodeType = BinaryContentTypes.Node)]
    public CameraPeer CameraPeer { get; set; }

    [BinaryContent(Name = "SyncedStatesArray", NodeType = BinaryContentTypes.Node)]
    public SyncedStatesArray SyncedStatesArray { get; set; }
  }
}