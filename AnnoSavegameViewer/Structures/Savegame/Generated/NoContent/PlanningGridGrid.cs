using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlanningGridGrid {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PlanningGridGridList> PlanningGridGridList { get; set; }

  }
}