using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaConstructionAI {

    [BinaryContent(Name = "LastQuery", NodeType = BinaryContentTypes.Attribute)]
    public object LastQuery { get; set; }

    [BinaryContent(Name = "AI Time", NodeType = BinaryContentTypes.Attribute)]
    public object AI_Time { get; set; }

    [BinaryContent(Name = "PermissionQueryCount", NodeType = BinaryContentTypes.Attribute)]
    public object PermissionQueryCount { get; set; }

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

  }
}