using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SequenceData {

[BinaryContent(Name = "CurrentSequenceID", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentSequenceID { get; set; }

[BinaryContent(Name = "CurrentSequenceStartTime", NodeType = BinaryContentTypes.Attribute)]
public HexString CurrentSequenceStartTime { get; set; }

[BinaryContent(Name = "IdleSequenceID", NodeType = BinaryContentTypes.Attribute)]
public HexString IdleSequenceID { get; set; }

[BinaryContent(Name = "Dirty", NodeType = BinaryContentTypes.Attribute)]
public HexString Dirty { get; set; }

}
}
