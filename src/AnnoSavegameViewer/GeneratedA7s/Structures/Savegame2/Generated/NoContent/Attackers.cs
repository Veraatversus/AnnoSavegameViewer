namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Attackers {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AttackersList> AttackersList { get; set; }

  }
}