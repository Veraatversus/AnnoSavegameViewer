using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class VisitedHarbors {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public VisitedHarborsList VisitedHarborsList { get; set; }

  }
}