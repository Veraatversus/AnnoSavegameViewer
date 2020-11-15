using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PhotographyObjectSettingsValue {

[BinaryContent(Name = "ObjectSettings", NodeType = BinaryContentTypes.Attribute)]
public HexString ObjectSettings { get; set; }

[BinaryContent(Name = "CircleAreaPercentage", NodeType = BinaryContentTypes.Attribute)]
public HexString CircleAreaPercentage { get; set; }

[BinaryContent(Name = "LinkedNewspaperArticle", NodeType = BinaryContentTypes.Attribute)]
public HexString LinkedNewspaperArticle { get; set; }

}
}
