using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Context {

[BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ArticleGUID { get; set; }

[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
public ContextParticipantID ParticipantID { get; set; }

[BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
public HexString TownID { get; set; }

[BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
public ObjectRef ObjectRef { get; set; }

[BinaryContent(Name = "TownName", NodeType = BinaryContentTypes.Attribute)]
public HexString TownName { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public ContextOwner Owner { get; set; }

[BinaryContent(Name = "ParticipantName", NodeType = BinaryContentTypes.Attribute)]
public HexString ParticipantName { get; set; }

}
}
