using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PropagandaChancesListList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PropagandaChancesListListValue Value { get; set; }

  }
}