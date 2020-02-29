using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SettleMission {

    [BinaryContent(Name = "AssignedShip", NodeType = BinaryContentTypes.Node)]
    public AssignedShip AssignedShip { get; set; }

    [BinaryContent(Name = "SettleLocation", NodeType = BinaryContentTypes.Node)]
    public SettleLocation SettleLocation { get; set; }

    [BinaryContent(Name = "SettleParams", NodeType = BinaryContentTypes.Node)]
    public SettleParams SettleParams { get; set; }

  }
}