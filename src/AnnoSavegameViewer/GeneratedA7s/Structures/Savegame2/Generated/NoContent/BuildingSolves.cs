namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class BuildingSolves {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BuildingSolvesList> BuildingSolvesList { get; set; }

  }
}