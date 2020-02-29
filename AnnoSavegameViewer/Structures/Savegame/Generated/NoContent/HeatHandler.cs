using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HeatHandler {

    [BinaryContent(Name = "Heaters", NodeType = BinaryContentTypes.Node)]
    public Heaters Heaters { get; set; }

  }
}