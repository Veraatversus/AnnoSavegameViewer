namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Prios {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public object None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public PriosList PriosList { get; set; }

  }
}