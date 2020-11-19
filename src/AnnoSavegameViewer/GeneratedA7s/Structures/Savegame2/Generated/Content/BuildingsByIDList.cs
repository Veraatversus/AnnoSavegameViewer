namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BuildingsByIDList {

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "CenterPos", NodeType = BinaryContentTypes.Attribute)]
    public object CenterPos { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Attribute)]
    public object Rotation { get; set; }

    [BinaryContent(Name = "Variation", NodeType = BinaryContentTypes.Attribute)]
    public object Variation { get; set; }
  }
}