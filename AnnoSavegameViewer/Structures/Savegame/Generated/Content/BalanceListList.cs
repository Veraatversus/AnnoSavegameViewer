namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BalanceListList {

    #region Public Properties

    [BinaryContent(Name = "NetBalance", NodeType = BinaryContentTypes.Attribute)]
    public object NetBalance { get; set; }

    [BinaryContent(Name = "ProvidedFor", NodeType = BinaryContentTypes.Node)]
    public ProvidedFor ProvidedFor { get; set; }

    [BinaryContent(Name = "ProvidedBy", NodeType = BinaryContentTypes.Node)]
    public ProvidedBy ProvidedBy { get; set; }

    #endregion Public Properties
  }
}