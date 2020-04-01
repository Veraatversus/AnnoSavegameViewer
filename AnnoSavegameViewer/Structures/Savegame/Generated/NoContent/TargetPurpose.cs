using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TargetPurpose {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public TargetPurposeValue Value { get; set; }

  }
}