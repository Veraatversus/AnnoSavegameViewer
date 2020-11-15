namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class FogsOfWar {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FogsOfWarList> FogsOfWarList { get; set; }

  }
}