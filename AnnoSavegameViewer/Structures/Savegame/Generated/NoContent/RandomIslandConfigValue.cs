using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RandomIslandConfigValue {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfigValueType Type { get; set; }

    [BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
    public Difficulty Difficulty { get; set; }

  }
}