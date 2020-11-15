using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class HarborsValue {

[BinaryContent(Name = "OwnerID", NodeType = BinaryContentTypes.Node)]
public NoneOwnerID OwnerID { get; set; }

[BinaryContent(Name = "HaborID", NodeType = BinaryContentTypes.Attribute)]
public HexString HaborID { get; set; }

[BinaryContent(Name = "HaborType", NodeType = BinaryContentTypes.Node)]
public HaborType HaborType { get; set; }

[BinaryContent(Name = "LoadingPierMidPoint", NodeType = BinaryContentTypes.Attribute)]
public HexString LoadingPierMidPoint { get; set; }

[BinaryContent(Name = "AwayFromCoast", NodeType = BinaryContentTypes.Attribute)]
public HexString AwayFromCoast { get; set; }

[BinaryContent(Name = "LoadingPiers", NodeType = BinaryContentTypes.Node)]
public LoadingPiers LoadingPiers { get; set; }

[BinaryContent(Name = "WaitingQueueMap", NodeType = BinaryContentTypes.Node)]
public WaitingQueueMap WaitingQueueMap { get; set; }

}
}
