using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Orders {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OrdersList> OrdersList { get; set; }

  }
}