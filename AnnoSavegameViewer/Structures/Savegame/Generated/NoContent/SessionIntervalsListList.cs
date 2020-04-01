using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionIntervalsListList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SessionIntervalsListListValue Value { get; set; }

  }
}