using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FeedbackShips {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FeedbackShipsList> FeedbackShipsList { get; set; }

  }
}