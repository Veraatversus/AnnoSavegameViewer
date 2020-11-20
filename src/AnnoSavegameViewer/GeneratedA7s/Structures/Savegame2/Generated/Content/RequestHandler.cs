namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RequestHandler {

    [BinaryContent(Name = "LastTick", NodeType = BinaryContentTypes.Attribute)]
    public object LastTick { get; set; }

    [BinaryContent(Name = "LastConsistencyCheck", NodeType = BinaryContentTypes.Attribute)]
    public object LastConsistencyCheck { get; set; }

    [BinaryContent(Name = "AllRequests", NodeType = BinaryContentTypes.Node)]
    public AllRequests AllRequests { get; set; }

    [BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
    public Balance Balance { get; set; }

  }
}