using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PhotographyObjectSettingsList {

    [BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Attribute)]
    public object ObjectSettings { get; set; }

    [BinaryContent(Name = "CircleAreaPercentage", NodeType = BinaryContentTypes.Attribute)]
    public object CircleAreaPercentage { get; set; }

    [BinaryContent(Name = "LinkedNewspaperArticle", NodeType = BinaryContentTypes.Attribute)]
    public object LinkedNewspaperArticle { get; set; }

  }
}