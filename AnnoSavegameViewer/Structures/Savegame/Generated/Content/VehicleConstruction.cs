using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VehicleConstruction {

    [BinaryContent(Name = "UnlockedTradeShips", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockedTradeShips { get; set; }

    [BinaryContent(Name = "PendingCraftables", NodeType = BinaryContentTypes.Node)]
    public PendingCraftables PendingCraftables { get; set; }

  }
}