using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CachePerSessionList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CachePerSessionListValue Value { get; set; }

  }
}