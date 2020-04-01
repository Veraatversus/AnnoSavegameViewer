using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MessageStatesList {

    [BinaryContent(Name = "ForbidBefore", NodeType = BinaryContentTypes.Attribute)]
    public object ForbidBefore { get; set; }

    [BinaryContent(Name = "Executed", NodeType = BinaryContentTypes.Attribute)]
    public object Executed { get; set; }

    [BinaryContent(Name = "TriggerCounts", NodeType = BinaryContentTypes.Attribute)]
    public object TriggerCounts { get; set; }

  }
}