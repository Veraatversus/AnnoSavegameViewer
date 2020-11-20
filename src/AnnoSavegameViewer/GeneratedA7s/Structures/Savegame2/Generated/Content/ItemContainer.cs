namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ItemContainer {

    #region Public Properties

    [BinaryContent(Name = "KamikazeDecal", NodeType = BinaryContentTypes.Attribute)]
    public object KamikazeDecal { get; set; }

    [BinaryContent(Name = "SlotContainer", NodeType = BinaryContentTypes.Node)]
    public SlotContainer SlotContainer { get; set; }

    [BinaryContent(Name = "SocketContainer", NodeType = BinaryContentTypes.Node)]
    public SocketContainer SocketContainer { get; set; }

    #endregion Public Properties
  }
}