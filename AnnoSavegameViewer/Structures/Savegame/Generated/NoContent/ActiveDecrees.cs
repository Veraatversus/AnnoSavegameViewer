using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveDecrees {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActiveDecreesList> ActiveDecreesList { get; set; }

  }
}