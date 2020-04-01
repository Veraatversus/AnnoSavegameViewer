using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaManagers {

    [BinaryContent(Name = "AreaManager", NodeType = BinaryContentTypes.Node)]
    public List<AreaManager> AreaManager { get; set; }

  }
}