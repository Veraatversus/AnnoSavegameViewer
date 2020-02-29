using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiplomacyStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiplomacyStatesList> DiplomacyStatesList { get; set; }

  }
}