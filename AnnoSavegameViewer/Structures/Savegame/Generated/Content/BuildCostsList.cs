using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildCostsList {

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public object ProductGUID { get; set; }

    [BinaryContent(Name = "Amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

  }
}