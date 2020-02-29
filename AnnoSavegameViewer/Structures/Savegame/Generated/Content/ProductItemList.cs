using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ProductItemList {

    [BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
    public object ItemID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

  }
}