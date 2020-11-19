namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LoadingPier {

    #region Public Properties

    [BinaryContent(Name = "LoadingHarbourID", NodeType = BinaryContentTypes.Attribute)]
    public object LoadingHarbourID { get; set; }

    [BinaryContent(Name = "CurrentTradePartnerArray", NodeType = BinaryContentTypes.Node)]
    public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }

    #endregion Public Properties
  }
}