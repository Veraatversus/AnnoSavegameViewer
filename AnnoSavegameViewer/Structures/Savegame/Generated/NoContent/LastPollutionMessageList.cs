using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastPollutionMessageList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastPollutionMessageListValue Value { get; set; }

  }
}