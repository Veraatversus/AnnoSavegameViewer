using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NGT {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Attribute)]
    public object Data { get; set; }

  }
}