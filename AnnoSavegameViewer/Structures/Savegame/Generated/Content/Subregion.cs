using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Subregion {

    [BinaryContent(Name = "subregion", NodeType = BinaryContentTypes.Attribute)]
    public object SubregionItem { get; set; }

  }
}