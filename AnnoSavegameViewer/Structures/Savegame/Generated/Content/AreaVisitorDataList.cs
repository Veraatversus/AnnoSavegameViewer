using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaVisitorDataList {

    #region Public Properties

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "VisitorHarbor", NodeType = BinaryContentTypes.Attribute)]
    public object VisitorHarbor { get; set; }

    [BinaryContent(Name = "EstimatedShipArrival", NodeType = BinaryContentTypes.Attribute)]
    public object EstimatedShipArrival { get; set; }

    [BinaryContent(Name = "LastMaxVisitorUpdate", NodeType = BinaryContentTypes.Attribute)]
    public object LastMaxVisitorUpdate { get; set; }

    [BinaryContent(Name = "VisitorHarberDestructionT", NodeType = BinaryContentTypes.Attribute)]
    public object VisitorHarberDestructionT { get; set; }

    [BinaryContent(Name = "SpecialistNot", NodeType = BinaryContentTypes.Attribute)]
    public object SpecialistNot { get; set; }

    [BinaryContent(Name = "OptimalVisitors", NodeType = BinaryContentTypes.Attribute)]
    public object OptimalVisitors { get; set; }

    [BinaryContent(Name = "VisitorIncome", NodeType = BinaryContentTypes.Attribute)]
    public object VisitorIncome { get; set; }

    [BinaryContent(Name = "Tier", NodeType = BinaryContentTypes.Attribute)]
    public object Tier { get; set; }

    [BinaryContent(Name = "CurrentVisitors", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentVisitors { get; set; }

    [BinaryContent(Name = "FirstShipArrived", NodeType = BinaryContentTypes.Attribute)]
    public object FirstShipArrived { get; set; }

    [BinaryContent(Name = "PrognoseTriggered", NodeType = BinaryContentTypes.Attribute)]
    public object PrognoseTriggered { get; set; }

    [BinaryContent(Name = "Specialist", NodeType = BinaryContentTypes.Node)]
    public Specialist Specialist { get; set; }

    #endregion Public Properties
  }
}