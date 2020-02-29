using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SettleHandler {

    [BinaryContent(Name = "LastSettleTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastSettleTime { get; set; }

    [BinaryContent(Name = "NextSettleMissionID", NodeType = BinaryContentTypes.Attribute)]
    public object NextSettleMissionID { get; set; }

    [BinaryContent(Name = "SettleMission", NodeType = BinaryContentTypes.Node)]
    public SettleMission SettleMission { get; set; }

  }
}