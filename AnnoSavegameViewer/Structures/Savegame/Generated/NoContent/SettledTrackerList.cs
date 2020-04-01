using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SettledTrackerList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SettledTrackerListValue Value { get; set; }

  }
}