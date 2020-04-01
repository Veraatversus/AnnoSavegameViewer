using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CargoItems {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CargoItemsList> CargoItemsList { get; set; }

  }
}