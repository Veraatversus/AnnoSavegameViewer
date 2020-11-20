namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Grid {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GridList> GridList { get; set; }

  }
}