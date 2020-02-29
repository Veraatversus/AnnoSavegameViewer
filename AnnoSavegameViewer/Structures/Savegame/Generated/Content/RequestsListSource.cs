using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequestsListSource {

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Attribute)]
    public object Source { get; set; }

  }
}