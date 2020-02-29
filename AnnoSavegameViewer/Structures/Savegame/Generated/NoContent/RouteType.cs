using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RouteType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RouteTypeValue Value { get; set; }

  }
}