using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Ministry {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public MinistryValue Value { get; set; }

  }
}