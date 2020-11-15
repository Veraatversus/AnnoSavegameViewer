namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MineProhibitZonesList {

    [BinaryContent(Name = "center", NodeType = BinaryContentTypes.Attribute)]
    public object Center { get; set; }

    [BinaryContent(Name = "radius", NodeType = BinaryContentTypes.Attribute)]
    public object Radius { get; set; }

    [BinaryContent(Name = "area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

  }
}