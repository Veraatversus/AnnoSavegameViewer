namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class VisitedHarbors {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VisitedHarborsList> VisitedHarborsList { get; set; }

  }
}