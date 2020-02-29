using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Grid {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<GridList> GridList { get; set; }

  }
}