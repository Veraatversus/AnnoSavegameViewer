namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class MapTemplate {

    [BinaryContent(Name = "Size", NodeType = BinaryContentTypes.Attribute)]
    public object Size { get; set; }

    [BinaryContent(Name = "PlayableArea", NodeType = BinaryContentTypes.Attribute)]
    public object PlayableArea { get; set; }

    [BinaryContent(Name = "Filename", NodeType = BinaryContentTypes.Attribute)]
    public object Filename { get; set; }

    [BinaryContent(Name = "ElementCount", NodeType = BinaryContentTypes.Attribute)]
    public object ElementCount { get; set; }

    [BinaryContent(Name = "RandomlyPlacedThirdParties", NodeType = BinaryContentTypes.Node)]
    public RandomlyPlacedThirdParties RandomlyPlacedThirdParties { get; set; }

    [BinaryContent(Name = "TemplateElement", NodeType = BinaryContentTypes.Node)]
    public List<TemplateElement> TemplateElement { get; set; }
  }
}