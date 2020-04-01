using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TransportationType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TransportationTypeValue Value { get; set; }

  }
}