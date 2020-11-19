namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MonumentHandler {

    [BinaryContent(Name = "CurrentConstruction", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentConstruction { get; set; }

    [BinaryContent(Name = "Timestamp", NodeType = BinaryContentTypes.Attribute)]
    public object Timestamp { get; set; }

    [BinaryContent(Name = "SavedResources", NodeType = BinaryContentTypes.Node)]
    public SavedResources SavedResources { get; set; }

  }
}