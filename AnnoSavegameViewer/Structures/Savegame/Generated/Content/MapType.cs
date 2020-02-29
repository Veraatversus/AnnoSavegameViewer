using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MapType {

    [BinaryContent(Name = "mapType", NodeType = BinaryContentTypes.Attribute)]
    public object MapTypeItem { get; set; }

  }
}