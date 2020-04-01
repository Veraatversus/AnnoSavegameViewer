using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Allies {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AlliesList> AlliesList { get; set; }

  }
}