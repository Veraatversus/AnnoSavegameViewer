using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FogOfWarObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FogOfWarObjectsList> FogOfWarObjectsList { get; set; }

  }
}