using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ParticipantRelation {

[BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
public Source Source { get; set; }

[BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
public ParticipantRelationTarget Target { get; set; }

}
}
