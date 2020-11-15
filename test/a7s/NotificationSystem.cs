using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NotificationSystem {

[BinaryContent(Name = "LocalPeer", NodeType = BinaryContentTypes.Node)]
public LocalPeer LocalPeer { get; set; }

[BinaryContent(Name = "Queue", NodeType = BinaryContentTypes.Node)]
public Queue Queue { get; set; }

[BinaryContent(Name = "IDCounter", NodeType = BinaryContentTypes.Attribute)]
public HexString IDCounter { get; set; }

[BinaryContent(Name = "Archive", NodeType = BinaryContentTypes.Node)]
public Archive Archive { get; set; }

[BinaryContent(Name = "FilterArrays", NodeType = BinaryContentTypes.Node)]
public FilterArrays FilterArrays { get; set; }

}
}
