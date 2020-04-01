using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReceivedPermissionInfo {

    [BinaryContent(Name = "LastChange", NodeType = BinaryContentTypes.Attribute)]
    public object LastChange { get; set; }

  }
}