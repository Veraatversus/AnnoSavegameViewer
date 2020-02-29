using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ItemTrade {

    [BinaryContent(Name = "LastReroll", NodeType = BinaryContentTypes.Attribute)]
    public object LastReroll { get; set; }

    [BinaryContent(Name = "Items", NodeType = BinaryContentTypes.Node)]
    public Items Items { get; set; }

  }
}