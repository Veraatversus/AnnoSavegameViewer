using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PossibleThirdParties {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PossibleThirdPartiesList> PossibleThirdPartiesList { get; set; }

  }
}