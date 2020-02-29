using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DivingBellObjectInfoListList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
    public object CargoGUID { get; set; }

    [BinaryContent(Name = "IsTreasure", NodeType = BinaryContentTypes.Attribute)]
    public object IsTreasure { get; set; }

  }
}