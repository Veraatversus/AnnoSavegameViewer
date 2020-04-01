using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EnterSessionMission {

    [BinaryContent(Name = "PendingMission", NodeType = BinaryContentTypes.Attribute)]
    public object PendingMission { get; set; }

  }
}