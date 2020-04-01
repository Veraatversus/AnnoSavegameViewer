using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaTriggeredList {

    [BinaryContent(Name = "Area", NodeType = BinaryContentTypes.Attribute)]
    public object Area { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

  }
}