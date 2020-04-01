using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildCosts {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public BuildCostsList BuildCostsList { get; set; }

  }
}