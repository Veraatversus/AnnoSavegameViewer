namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BaseNode {

    [BinaryContent(Name = "MetaGameManager", NodeType = BinaryContentTypes.Node)]
    public MetaGameManager MetaGameManager { get; set; }

  }
}