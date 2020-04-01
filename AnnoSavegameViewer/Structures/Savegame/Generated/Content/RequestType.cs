using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequestType {

    [BinaryContent(Name = "RequestType", NodeType = BinaryContentTypes.Attribute)]
    public object RequestTypeItem { get; set; }

  }
}