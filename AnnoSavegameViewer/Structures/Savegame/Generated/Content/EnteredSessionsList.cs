using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EnteredSessionsList {

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "Roles", NodeType = BinaryContentTypes.Attribute)]
    public object Roles { get; set; }

    [BinaryContent(Name = "Time", NodeType = BinaryContentTypes.Attribute)]
    public object Time { get; set; }

  }
}