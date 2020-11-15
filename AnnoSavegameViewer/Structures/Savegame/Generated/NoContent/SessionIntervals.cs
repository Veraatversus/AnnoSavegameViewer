namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class SessionIntervals {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SessionIntervalsList> SessionIntervalsList { get; set; }

  }
}