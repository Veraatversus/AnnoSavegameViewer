using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ValuesNoneContext {

[BinaryContent(Name = "ArticleGUID", NodeType = BinaryContentTypes.Attribute)]
public HexString ArticleGUID { get; set; }

[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
public ValuesNoneContextParticipantID ParticipantID { get; set; }

[BinaryContent(Name = "TownID", NodeType = BinaryContentTypes.Attribute)]
public HexString TownID { get; set; }

[BinaryContent(Name = "ObjectRef", NodeType = BinaryContentTypes.Node)]
public NoneContextObjectRef ObjectRef { get; set; }

[BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
public ValuesNoneContextOwner Owner { get; set; }

}
}
