namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class VirtualSlotsListList {

    [BinaryContent(Name = "OccupierID", NodeType = BinaryContentTypes.Attribute)]
    public object OccupierID { get; set; }

    [BinaryContent(Name = "AABB", NodeType = BinaryContentTypes.Attribute)]
    public object AABB { get; set; }

    [BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
    public object Center { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Node)]
    public VirtualSlotsListListRotation Rotation { get; set; }

  }
}