using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CrisesList {

    [BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    [BinaryContent(Name = "Creation", NodeType = BinaryContentTypes.Attribute)]
    public object Creation { get; set; }

    [BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
    public object Product { get; set; }

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public Type Type { get; set; }

  }
}