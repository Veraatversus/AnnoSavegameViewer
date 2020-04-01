using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ThirdParty {

    [BinaryContent(Name = "NextReservationTime", NodeType = BinaryContentTypes.Attribute)]
    public object NextReservationTime { get; set; }

  }
}