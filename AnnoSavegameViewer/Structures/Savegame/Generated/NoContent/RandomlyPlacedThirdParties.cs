using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RandomlyPlacedThirdParties {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<RandomlyPlacedThirdPartiesList> RandomlyPlacedThirdPartiesList { get; set; }

  }
}