using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class NewspaperManagerIDManager {

    [BinaryContent(Name = "NextID", NodeType = BinaryContentTypes.Attribute)]
    public object NextID { get; set; }

    [BinaryContent(Name = "FreeIDList", NodeType = BinaryContentTypes.Node)]
    public NewspaperManagerIDManagerFreeIDList FreeIDList { get; set; }

    [BinaryContent(Name = "HotIDList", NodeType = BinaryContentTypes.Node)]
    public NewspaperManagerIDManagerHotIDList HotIDList { get; set; }

  }
}