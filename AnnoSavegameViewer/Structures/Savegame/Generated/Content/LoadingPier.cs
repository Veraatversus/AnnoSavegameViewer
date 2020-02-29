using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LoadingPier {

    [BinaryContent(Name = "LoadingHarbourID", NodeType = BinaryContentTypes.Attribute)]
    public object LoadingHarbourID { get; set; }

    [BinaryContent(Name = "CurrentTradePartnerArray", NodeType = BinaryContentTypes.Node)]
    public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }

  }
}