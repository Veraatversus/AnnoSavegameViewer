using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TransportType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TransportTypeValue Value { get; set; }

  }
}