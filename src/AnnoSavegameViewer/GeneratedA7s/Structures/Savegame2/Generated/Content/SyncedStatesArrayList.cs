namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SyncedStatesArrayList {

    [BinaryContent(Name = "PresetId", NodeType = BinaryContentTypes.Attribute)]
    public object PresetId { get; set; }

    [BinaryContent(Name = "View", NodeType = BinaryContentTypes.Node)]
    public SyncedStatesArrayListView View { get; set; }

    [BinaryContent(Name = "Projection", NodeType = BinaryContentTypes.Node)]
    public SyncedStatesArrayListProjection Projection { get; set; }

  }
}