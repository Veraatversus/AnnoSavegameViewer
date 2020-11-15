namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Allies {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AlliesList> AlliesList { get; set; }

  }
}