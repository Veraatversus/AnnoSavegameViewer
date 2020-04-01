using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionHandler {

    [BinaryContent(Name = "EnteredSessions", NodeType = BinaryContentTypes.Node)]
    public EnteredSessions EnteredSessions { get; set; }

    [BinaryContent(Name = "EnterSessionMission", NodeType = BinaryContentTypes.Node)]
    public EnterSessionMission EnterSessionMission { get; set; }

  }
}