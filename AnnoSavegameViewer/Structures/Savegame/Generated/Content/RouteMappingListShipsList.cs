using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RouteMappingListShipsList {

    [BinaryContent(Name = "ShipObject", NodeType = BinaryContentTypes.Attribute)]
    public object ShipObject { get; set; }

    [BinaryContent(Name = "CurrentArea", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentArea { get; set; }

    [BinaryContent(Name = "DestinationArea", NodeType = BinaryContentTypes.Attribute)]
    public object DestinationArea { get; set; }

    [BinaryContent(Name = "Route", NodeType = BinaryContentTypes.Attribute)]
    public object Route { get; set; }

    [BinaryContent(Name = "ShipState", NodeType = BinaryContentTypes.Node)]
    public ShipState ShipState { get; set; }

  }
}