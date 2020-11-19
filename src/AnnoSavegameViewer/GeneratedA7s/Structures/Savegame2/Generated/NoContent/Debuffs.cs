namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Debuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DebuffsList> DebuffsList { get; set; }

  }
}