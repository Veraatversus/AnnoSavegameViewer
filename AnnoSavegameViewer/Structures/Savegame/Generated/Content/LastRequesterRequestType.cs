using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastRequesterRequestType {

    [BinaryContent(Name = "RequestType", NodeType = BinaryContentTypes.Attribute)]
    public object RequestType { get; set; }

  }
}