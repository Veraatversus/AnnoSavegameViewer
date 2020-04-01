using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FakeQuestTrackerItemList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public FakeQuestTrackerItemListList FakeQuestTrackerItemListList { get; set; }

  }
}