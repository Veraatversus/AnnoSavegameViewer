using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SquadUnitsList {

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public object ID { get; set; }

  }
}