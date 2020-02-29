using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Region {

    [BinaryContent(Name = "region", NodeType = BinaryContentTypes.Attribute)]
    public object RegionItem { get; set; }

  }
}