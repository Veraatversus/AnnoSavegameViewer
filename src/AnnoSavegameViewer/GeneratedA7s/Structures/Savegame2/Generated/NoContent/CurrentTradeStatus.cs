namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CurrentTradeStatus {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CurrentTradeStatusList> CurrentTradeStatusList { get; set; }

  }
}