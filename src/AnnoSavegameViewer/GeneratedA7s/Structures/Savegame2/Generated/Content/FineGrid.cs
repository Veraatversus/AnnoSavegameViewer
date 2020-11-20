namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class FineGrid {

    [BinaryContent(Name = "AreaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "Origin", NodeType = BinaryContentTypes.Attribute)]
    public object Origin { get; set; }

    [BinaryContent(Name = "Max", NodeType = BinaryContentTypes.Attribute)]
    public object Max { get; set; }

    [BinaryContent(Name = "Dimensions", NodeType = BinaryContentTypes.Attribute)]
    public object Dimensions { get; set; }

    [BinaryContent(Name = "LandBuildableRect", NodeType = BinaryContentTypes.Attribute)]
    public object LandBuildableRect { get; set; }

    [BinaryContent(Name = "FineGridData", NodeType = BinaryContentTypes.Attribute)]
    public object FineGridData { get; set; }
  }
}