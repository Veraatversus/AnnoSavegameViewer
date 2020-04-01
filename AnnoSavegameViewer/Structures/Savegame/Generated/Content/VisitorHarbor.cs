using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VisitorHarbor {

    [BinaryContent(Name = "VisitorHarborRegistered", NodeType = BinaryContentTypes.Attribute)]
    public object VisitorHarborRegistered { get; set; }

  }
}