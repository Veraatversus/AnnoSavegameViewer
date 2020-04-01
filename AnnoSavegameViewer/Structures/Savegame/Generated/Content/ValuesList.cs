using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ValuesList {

    [BinaryContent(Name = "data", NodeType = BinaryContentTypes.Attribute)]
    public object Data { get; set; }

  }
}