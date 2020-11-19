namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Sellable {

    [BinaryContent(Name = "allowedBuyers", NodeType = BinaryContentTypes.Attribute)]
    public object AllowedBuyers { get; set; }

    [BinaryContent(Name = "onSale", NodeType = BinaryContentTypes.Attribute)]
    public object OnSale { get; set; }

  }
}