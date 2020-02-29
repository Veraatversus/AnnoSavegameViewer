using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaSoundManager {

    [BinaryContent(Name = "firstEncounterMusic", NodeType = BinaryContentTypes.Node)]
    public FirstEncounterMusic FirstEncounterMusic { get; set; }

  }
}