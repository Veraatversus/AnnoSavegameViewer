namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Items {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ItemsList> ItemsList { get; set; }

  }
}