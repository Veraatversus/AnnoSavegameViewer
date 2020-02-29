using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingSolves {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<BuildingSolvesList> BuildingSolvesList { get; set; }

  }
}