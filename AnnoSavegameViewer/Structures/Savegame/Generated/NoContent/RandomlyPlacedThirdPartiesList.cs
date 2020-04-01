using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RandomlyPlacedThirdPartiesList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RandomlyPlacedThirdPartiesListValue Value { get; set; }

  }
}