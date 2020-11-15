using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class MapTemplate {

[BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Attribute)]
public HexString Size { get; set; }

[BinaryContent(Name = "PlayableArea", NodeType = BinaryContentTypes.Attribute)]
public HexString PlayableArea { get; set; }

[BinaryContent(Name = "RandomlyPlacedThirdParties", NodeType = BinaryContentTypes.Node)]
public RandomlyPlacedThirdParties RandomlyPlacedThirdParties { get; set; }

[BinaryContent(Name = "Filename", NodeType = BinaryContentTypes.Attribute)]
public HexString Filename { get; set; }

[BinaryContent(Name = "ElementCount", NodeType = BinaryContentTypes.Attribute)]
public HexString ElementCount { get; set; }

[BinaryContent(Name = "TemplateElement", NodeType = BinaryContentTypes.Node)]
public TemplateElement TemplateElement { get; set; }

}
}
