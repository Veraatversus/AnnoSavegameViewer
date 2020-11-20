namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class LastKilled {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LastKilledList> LastKilledList { get; set; }

  }
}