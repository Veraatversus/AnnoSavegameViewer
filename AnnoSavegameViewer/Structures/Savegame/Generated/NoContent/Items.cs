using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Items {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ItemsList> ItemsList { get; set; }

  }
}