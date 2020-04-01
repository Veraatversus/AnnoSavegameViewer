using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EconomyStatisticManager {

    [BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
    public History History { get; set; }

  }
}