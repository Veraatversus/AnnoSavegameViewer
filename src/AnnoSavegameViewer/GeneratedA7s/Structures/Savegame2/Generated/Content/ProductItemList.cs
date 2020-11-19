namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ProductItemList {

    [BinaryContent(Name = "ItemID", NodeType = BinaryContentTypes.Attribute)]
    public object ItemID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

  }
}