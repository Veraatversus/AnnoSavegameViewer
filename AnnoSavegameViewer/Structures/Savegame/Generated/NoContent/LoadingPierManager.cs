using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LoadingPierManager {

    [BinaryContent(Name = "Harbors", NodeType = BinaryContentTypes.Node)]
    public Harbors Harbors { get; set; }

  }
}