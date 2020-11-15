namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RouteMapList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Name", NodeType = BinaryContentTypes.Attribute)]
    public object Name { get; set; }

    [BinaryContent(Name = "Ships", NodeType = BinaryContentTypes.Attribute)]
    public ListOfInt64 Ships { get; set; }

    [BinaryContent(Name = "LastErrors", NodeType = BinaryContentTypes.Attribute)]
    public object LastErrors { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public RouteMapListOwner Owner { get; set; }

    [BinaryContent(Name = "OwnerType", NodeType = BinaryContentTypes.Node)]
    public OwnerType OwnerType { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public RouteMapListType Type { get; set; }

    [BinaryContent(Name = "Stations", NodeType = BinaryContentTypes.Node)]
    public Stations Stations { get; set; }

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public RouteMapListIDManager IDManager { get; set; }

    [BinaryContent(Name = "CharterRouteDescription", NodeType = BinaryContentTypes.Node)]
    public CharterRouteDescription CharterRouteDescription { get; set; }

  }
}