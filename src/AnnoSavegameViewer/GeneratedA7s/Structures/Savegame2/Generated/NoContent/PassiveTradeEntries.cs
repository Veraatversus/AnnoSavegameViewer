namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PassiveTradeEntries {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PassiveTradeEntriesList> PassiveTradeEntriesList { get; set; }

  }
}