namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SessionCounterListCountersListList {

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
    public object Context { get; set; }

    [BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

    [BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
    public SessionCounterListCountersListListPlayerCounter PlayerCounter { get; set; }

  }
}