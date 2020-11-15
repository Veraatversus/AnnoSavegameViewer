using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PeerToSessionMapValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public NoneValue Value { get; set; }

[BinaryContent(Name = "LastActiveSession", NodeType = BinaryContentTypes.Attribute)]
public HexString LastActiveSession { get; set; }

[BinaryContent(Name = "CurrentlyActiveSession", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentlyActiveSession { get; set; }

}
}
