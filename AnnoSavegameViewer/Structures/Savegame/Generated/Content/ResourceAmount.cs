using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ResourceAmount {

    [BinaryContent(Name = "resourceAmount", NodeType = BinaryContentTypes.Attribute)]
    public object ResourceAmountItem { get; set; }

  }
}