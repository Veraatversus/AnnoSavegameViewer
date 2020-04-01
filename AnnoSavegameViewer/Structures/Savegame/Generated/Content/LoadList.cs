using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LoadList {

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGUID { get; set; }

    [BinaryContent(Name = "ProductAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ProductAmount { get; set; }

  }
}