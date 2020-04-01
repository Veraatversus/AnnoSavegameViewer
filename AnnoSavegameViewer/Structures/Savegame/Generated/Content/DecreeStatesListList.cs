using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DecreeStatesListList {

    [BinaryContent(Name = "UnlockedState", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockedState { get; set; }

    [BinaryContent(Name = "FirstTimeUnlockAcknowledgedState", NodeType = BinaryContentTypes.Attribute)]
    public object FirstTimeUnlockAcknowledgedState { get; set; }

  }
}