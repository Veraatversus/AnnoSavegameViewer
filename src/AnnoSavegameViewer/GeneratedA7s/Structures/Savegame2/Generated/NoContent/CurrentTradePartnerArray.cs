namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CurrentTradePartnerArray {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CurrentTradePartnerArrayList> CurrentTradePartnerArrayList { get; set; }

  }
}