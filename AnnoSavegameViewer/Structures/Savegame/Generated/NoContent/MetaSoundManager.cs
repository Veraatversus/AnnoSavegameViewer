using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaSoundManager {

    [BinaryContent(Name = "firstEncounterMusic", NodeType = BinaryContentTypes.Node)]
    public FirstEncounterMusic FirstEncounterMusic { get; set; }

  }
}