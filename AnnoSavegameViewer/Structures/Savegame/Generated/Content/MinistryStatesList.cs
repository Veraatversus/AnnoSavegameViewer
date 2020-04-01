using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MinistryStatesList {

    [BinaryContent(Name = "UnlockedState", NodeType = BinaryContentTypes.Attribute)]
    public object UnlockedState { get; set; }

  }
}