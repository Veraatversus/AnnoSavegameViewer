using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TransporterID {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object Type { get; set; }

    [BinaryContent(Name = "Index", NodeType = BinaryContentTypes.Attribute)]
    public object Index { get; set; }

    [BinaryContent(Name = "Parent", NodeType = BinaryContentTypes.Node)]
    public TransporterIDParent Parent { get; set; }

  }
}