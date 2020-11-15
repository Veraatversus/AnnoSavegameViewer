namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CachePerSessionList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CachePerSessionListValue Value { get; set; }

  }
}