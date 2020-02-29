using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SettledTracker {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SettledTrackerList> SettledTrackerList { get; set; }

  }
}