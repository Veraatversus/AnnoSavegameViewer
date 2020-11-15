namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SettledTracker {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SettledTrackerList> SettledTrackerList { get; set; }

  }
}