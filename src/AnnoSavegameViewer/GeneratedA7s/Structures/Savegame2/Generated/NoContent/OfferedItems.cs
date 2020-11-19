namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class OfferedItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OfferedItemsList> OfferedItemsList { get; set; }

  }
}