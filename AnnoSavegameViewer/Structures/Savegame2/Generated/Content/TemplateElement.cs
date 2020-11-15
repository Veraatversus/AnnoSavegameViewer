namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class TemplateElement {

    [BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Attribute)]
    public object ElementType { get; set; }

    [BinaryContent(Name = "Element", NodeType = BinaryContentTypes.Node)]
    public TemplateElementElement Element { get; set; }

  }
}