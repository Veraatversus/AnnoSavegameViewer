using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ThreadState {

[BinaryContent(Name = "LastReservationTime", NodeType = BinaryContentTypes.Attribute)]
public HexString LastReservationTime { get; set; }

[BinaryContent(Name = "ThreadStateOfEachPeer", NodeType = BinaryContentTypes.Node)]
public ThreadStateOfEachPeer ThreadStateOfEachPeer { get; set; }

[BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
public ThreadStateState State { get; set; }

[BinaryContent(Name = "RequestingSessions", NodeType = BinaryContentTypes.Attribute)]
public HexString RequestingSessions { get; set; }

}
}
