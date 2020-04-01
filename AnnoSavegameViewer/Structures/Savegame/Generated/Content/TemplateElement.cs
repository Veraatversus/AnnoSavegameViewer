using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TemplateElement {

    [BinaryContent(Name = "ElementType", NodeType = BinaryContentTypes.Attribute)]
    public object ElementType { get; set; }

    [BinaryContent(Name = "Element", NodeType = BinaryContentTypes.Node)]
    public TemplateElementElement Element { get; set; }

  }
}