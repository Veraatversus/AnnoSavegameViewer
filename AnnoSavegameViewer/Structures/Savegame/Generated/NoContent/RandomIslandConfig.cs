using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RandomIslandConfig {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfigValue Value { get; set; }

  }
}