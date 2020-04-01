using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShipIncident {

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
    public ActiveType ActiveType { get; set; }

  }
}