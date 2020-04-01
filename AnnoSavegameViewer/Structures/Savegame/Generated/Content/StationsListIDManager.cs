using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StationsListIDManager {

    [BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
    public object NextID { get; set; }

    [BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
    public StationsListIDManagerFreeIDList FreeIDList { get; set; }

    [BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
    public StationsListIDManagerHotIDList HotIDList { get; set; }

  }
}