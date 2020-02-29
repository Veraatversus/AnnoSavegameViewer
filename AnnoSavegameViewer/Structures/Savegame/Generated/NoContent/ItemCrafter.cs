using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ItemCrafter {

    [BinaryContent(Name = "ItemStorage", NodeType = BinaryContentTypes.Node)]
    public ItemStorage ItemStorage { get; set; }

  }
}