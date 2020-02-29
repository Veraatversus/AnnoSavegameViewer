using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SlotPositionsList {

    [BinaryContent(Name = "Position", NodeType = BinaryContentTypes.Attribute)]
    public object Position { get; set; }

    [BinaryContent(Name = "ObjectID", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectID { get; set; }

    [BinaryContent(Name = "OccupierID", NodeType = BinaryContentTypes.Attribute)]
    public object OccupierID { get; set; }

    [BinaryContent(Name = "AABB", NodeType = BinaryContentTypes.Attribute)]
    public object AABB { get; set; }

    [BinaryContent(Name = "Rotation", NodeType = BinaryContentTypes.Node)]
    public Rotation Rotation { get; set; }

    [BinaryContent(Name = "SlotType", NodeType = BinaryContentTypes.Node)]
    public SlotType SlotType { get; set; }

  }
}