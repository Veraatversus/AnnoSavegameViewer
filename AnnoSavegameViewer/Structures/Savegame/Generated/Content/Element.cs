using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Element {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
    public object Data { get; set; }

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

    [BinaryContent(Name = "Delta", NodeType = BinaryContentTypes.Attribute)]
    public object Delta { get; set; }

  }
}