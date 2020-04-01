using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SpecificColorType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public SpecificColorTypeValue Value { get; set; }

  }
}