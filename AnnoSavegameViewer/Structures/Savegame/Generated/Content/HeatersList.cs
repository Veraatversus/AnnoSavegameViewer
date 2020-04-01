using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HeatersList {

    [BinaryContent(Name = "IsCity", NodeType = BinaryContentTypes.Attribute)]
    public object IsCity { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Center", NodeType = BinaryContentTypes.Attribute)]
    public object Center { get; set; }

    [BinaryContent(Name = "Rect", NodeType = BinaryContentTypes.Attribute)]
    public object Rect { get; set; }

  }
}