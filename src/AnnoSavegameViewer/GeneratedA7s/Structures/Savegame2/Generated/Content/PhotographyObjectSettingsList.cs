namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class PhotographyObjectSettingsList {

    [BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectSettings { get; set; }

    [BinaryContent(Name = "CircleAreaPercentage", NodeType = BinaryContentTypes.Attribute)]
    public object CircleAreaPercentage { get; set; }

    [BinaryContent(Name = "LinkedNewspaperArticle", NodeType = BinaryContentTypes.Attribute)]
    public object LinkedNewspaperArticle { get; set; }

  }
}