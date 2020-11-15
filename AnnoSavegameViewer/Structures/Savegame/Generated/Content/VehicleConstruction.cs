namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VehicleConstruction {

    [BinaryContent(Name = "UnlockedTradeShips", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockedTradeShips { get; set; }

    [BinaryContent(Name = "PendingCraftables", NodeType = BinaryContentTypes.Node)]
    public PendingCraftables PendingCraftables { get; set; }

  }
}