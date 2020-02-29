using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveTradeHandlerShipsList {

    #region Public Properties

    [BinaryContent(Name = "guid", NodeType = BinaryContentTypes.Attribute)]
    public object Guid { get; set; }

    [BinaryContent(Name = "ship", NodeType = BinaryContentTypes.Node)]
    public ActiveTradeHandlerShipsListShip Ship { get; set; }

    #endregion Public Properties
  }
}