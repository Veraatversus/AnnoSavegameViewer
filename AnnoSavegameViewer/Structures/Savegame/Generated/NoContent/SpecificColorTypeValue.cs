using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpecificColorTypeValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SpecificColorTypeValueValue Value { get; set; }

  }
}