namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemReference {

    #region Public Properties

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public long ID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public int GUID { get; set; }

    #endregion Public Properties
  }
}