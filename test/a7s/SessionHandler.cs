using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionHandler {

[BinaryContent(Name = "EnteredSessions", NodeType = BinaryContentTypes.Node)]
public EnteredSessions EnteredSessions { get; set; }

[BinaryContent(Name = "EnterSessionMission", NodeType = BinaryContentTypes.Node)]
public EnterSessionMission EnterSessionMission { get; set; }

}
}
