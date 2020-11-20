namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GameObject {

    #region Public Properties

    [BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
    public GameObjectObjects Objects { get; set; }

    #endregion Public Properties
  }
}