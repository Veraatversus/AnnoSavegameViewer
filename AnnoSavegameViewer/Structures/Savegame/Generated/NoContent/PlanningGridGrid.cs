namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PlanningGridGrid {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PlanningGridGridList> PlanningGridGridList { get; set; }

  }
}