using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class GroupsList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

    [BinaryContent(Name = "Units", NodeType = BinaryContentTypes.Attribute)]
    public object Units { get; set; }

  }
}