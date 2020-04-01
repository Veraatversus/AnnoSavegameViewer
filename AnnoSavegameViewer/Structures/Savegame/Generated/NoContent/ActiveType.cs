using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveTypeValue Value { get; set; }

  }
}