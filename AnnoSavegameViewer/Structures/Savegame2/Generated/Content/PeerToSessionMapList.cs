namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PeerToSessionMapList {

    [BinaryContent(Name = "LastActiveSession", NodeType = BinaryContentTypes.Attribute)]
    public object LastActiveSession { get; set; }

    [BinaryContent(Name = "CurrentlyActiveSession", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentlyActiveSession { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PeerToSessionMapListValue Value { get; set; }

  }
}