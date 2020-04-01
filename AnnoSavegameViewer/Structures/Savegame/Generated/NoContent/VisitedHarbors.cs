using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VisitedHarbors {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<VisitedHarborsList> VisitedHarborsList { get; set; }

  }
}