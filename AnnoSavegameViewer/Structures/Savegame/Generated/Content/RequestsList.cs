using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequestsList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
    public object TargetSession { get; set; }

    [BinaryContent(Name = "ProductionGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductionGUID { get; set; }

    [BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Attribute)]
    public object Ship { get; set; }

    [BinaryContent(Name = "RequestGUID", NodeType = BinaryContentTypes.Attribute)]
    public object RequestGUID { get; set; }

    [BinaryContent(Name = "ProducedInSession", NodeType = BinaryContentTypes.Attribute)]
    public object ProducedInSession { get; set; }

    [BinaryContent(Name = "ProducedByBuilding", NodeType = BinaryContentTypes.Attribute)]
    public object ProducedByBuilding { get; set; }

    [BinaryContent(Name = "TargetPurpose", NodeType = BinaryContentTypes.Node)]
    public TargetPurpose TargetPurpose { get; set; }

    [BinaryContent(Name = "ShipRequirements", NodeType = BinaryContentTypes.Node)]
    public ShipRequirements ShipRequirements { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
    public Priority Priority { get; set; }

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public RequestsListSource Source { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public RequestsListState State { get; set; }

  }
}