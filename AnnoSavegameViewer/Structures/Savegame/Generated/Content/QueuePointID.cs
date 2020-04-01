using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class QueuePointID {

    [BinaryContent(Name = "InRowIndex", NodeType = BinaryContentTypes.Attribute)]
    public object InRowIndex { get; set; }

  }
}