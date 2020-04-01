using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DriftingInstruction {

    [BinaryContent(Name = "DriftingInstruction", NodeType = BinaryContentTypes.Attribute)]
    public object DriftingInstructionItem { get; set; }

  }
}