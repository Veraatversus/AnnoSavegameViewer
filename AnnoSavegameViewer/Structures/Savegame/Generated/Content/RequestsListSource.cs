using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RequestsListSource {

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Attribute)]
    public object Source { get; set; }

  }
}