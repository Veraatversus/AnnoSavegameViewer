using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTravel {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentTravelValue Value { get; set; }

  }
}