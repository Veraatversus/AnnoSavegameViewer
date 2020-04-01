using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueueEntryListListTransportationType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public QueueEntryListListTransportationTypeValue Value { get; set; }

  }
}