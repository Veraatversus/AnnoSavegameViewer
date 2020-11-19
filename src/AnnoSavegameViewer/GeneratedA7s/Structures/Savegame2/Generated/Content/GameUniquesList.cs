namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GameUniquesList {

    #region Public Properties

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public GameUniquesListType Type { get; set; }

    #endregion Public Properties
  }
}