using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IconsList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "VisibilityMask", NodeType = BinaryContentTypes.Attribute)]
    public object VisibilityMask { get; set; }

    [BinaryContent(Name = "ShowTime", NodeType = BinaryContentTypes.Attribute)]
    public object ShowTime { get; set; }

    [BinaryContent(Name = "HadCallback", NodeType = BinaryContentTypes.Attribute)]
    public object HadCallback { get; set; }

  }
}