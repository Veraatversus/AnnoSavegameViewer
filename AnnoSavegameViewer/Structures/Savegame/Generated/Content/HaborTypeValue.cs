using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HaborTypeValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

  }
}