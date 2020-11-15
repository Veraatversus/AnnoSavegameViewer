using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MetaConstructionAI {

[BinaryContent(Name = "ThreadState", NodeType = BinaryContentTypes.Node)]
public ThreadState ThreadState { get; set; }

[BinaryContent(Name = "SessionHandler", NodeType = BinaryContentTypes.Node)]
public SessionHandler SessionHandler { get; set; }

[BinaryContent(Name = "ShipHandler", NodeType = BinaryContentTypes.Node)]
public ShipHandler ShipHandler { get; set; }

[BinaryContent(Name = "MetaResourceHandler", NodeType = BinaryContentTypes.Node)]
public MetaResourceHandler MetaResourceHandler { get; set; }

[BinaryContent(Name = "RequestHandler", NodeType = BinaryContentTypes.Node)]
public RequestHandler RequestHandler { get; set; }

[BinaryContent(Name = "TradeRouteHandler", NodeType = BinaryContentTypes.Node)]
public TradeRouteHandler TradeRouteHandler { get; set; }

[BinaryContent(Name = "ProblemDetector", NodeType = BinaryContentTypes.Node)]
public ProblemDetector ProblemDetector { get; set; }

[BinaryContent(Name = "CrisisHandler", NodeType = BinaryContentTypes.Node)]
public CrisisHandler CrisisHandler { get; set; }

[BinaryContent(Name = "UnlockHanlder", NodeType = BinaryContentTypes.Node)]
public UnlockHanlder UnlockHanlder { get; set; }

[BinaryContent(Name = "ConstructionMaterialHandler", NodeType = BinaryContentTypes.Node)]
public ConstructionMaterialHandler ConstructionMaterialHandler { get; set; }

[BinaryContent(Name = "LastQuery", NodeType = BinaryContentTypes.Attribute)]
public HexString LastQuery { get; set; }

[BinaryContent(Name = "AI Time", NodeType = BinaryContentTypes.Attribute)]
public HexString AI_Time { get; set; }

[BinaryContent(Name = "PermissionQueryCount", NodeType = BinaryContentTypes.Attribute)]
public HexString PermissionQueryCount { get; set; }

}
}
