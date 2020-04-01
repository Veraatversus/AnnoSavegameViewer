using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LastAttractivenessMessageList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public LastAttractivenessMessageListValue Value { get; set; }

  }
}