using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DebuffsList {

    [BinaryContent(Name = "DebuffEnd", NodeType = BinaryContentTypes.Attribute)]
    public object DebuffEnd { get; set; }

    [BinaryContent(Name = "DiceDebuff", NodeType = BinaryContentTypes.Attribute)]
    public object DiceDebuff { get; set; }

  }
}