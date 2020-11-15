namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class OptimizeRequests {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public object None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public OptimizeRequestsList OptimizeRequestsList { get; set; }

  }
}