using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiplomacyStatesList {

    [BinaryContent(Name = "ExpireTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object ExpireTimestamp { get; set; }

    [BinaryContent(Name = "FullTime", NodeType = BinaryContentTypes.Attribute)]
    public object FullTime { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public State State { get; set; }

  }
}