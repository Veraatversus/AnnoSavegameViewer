using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EscortDestinationInfo {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public EscortDestinationInfoList EscortDestinationInfoList { get; set; }

  }
}