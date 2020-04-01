using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Purpose {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public PurposeValue Value { get; set; }

  }
}