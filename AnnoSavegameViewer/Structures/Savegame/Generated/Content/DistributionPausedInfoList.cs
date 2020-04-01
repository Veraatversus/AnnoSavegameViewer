using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DistributionPausedInfoList {

    [BinaryContent(Name = "DistributionPaused", NodeType = BinaryContentTypes.Attribute)]
    public object DistributionPaused { get; set; }

    [BinaryContent(Name = "CurrentlyProvided", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentlyProvided { get; set; }

  }
}