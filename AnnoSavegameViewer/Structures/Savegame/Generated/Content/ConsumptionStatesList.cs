using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConsumptionStatesList {

    [BinaryContent(Name = "CurrentSaturation", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentSaturation { get; set; }

    [BinaryContent(Name = "AverageSaturation", NodeType = BinaryContentTypes.Attribute)]
    public object AverageSaturation { get; set; }

  }
}