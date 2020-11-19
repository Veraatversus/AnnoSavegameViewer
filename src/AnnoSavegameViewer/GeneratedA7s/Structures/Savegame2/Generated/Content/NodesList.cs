namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class NodesList {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "IsPersistent", NodeType = BinaryContentTypes.Attribute)]
    public object IsPersistent { get; set; }

  }
}