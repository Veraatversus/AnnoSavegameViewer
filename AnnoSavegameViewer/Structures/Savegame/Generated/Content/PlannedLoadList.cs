using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlannedLoadList {

    [BinaryContent(Name = "LoadGuid", NodeType = BinaryContentTypes.Attribute)]
    public object LoadGuid { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "UnloadGuid", NodeType = BinaryContentTypes.Attribute)]
    public object UnloadGuid { get; set; }

    [BinaryContent(Name = "UnloadAmount", NodeType = BinaryContentTypes.Attribute)]
    public object UnloadAmount { get; set; }

    [BinaryContent(Name = "LoadAmount", NodeType = BinaryContentTypes.Attribute)]
    public object LoadAmount { get; set; }

  }
}