namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class GoodInfos {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GoodInfosList> GoodInfosList { get; set; }

  }
}