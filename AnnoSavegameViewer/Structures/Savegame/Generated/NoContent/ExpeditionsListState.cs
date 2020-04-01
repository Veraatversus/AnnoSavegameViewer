using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ExpeditionsListState {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ExpeditionsListStateValue Value { get; set; }

  }
}