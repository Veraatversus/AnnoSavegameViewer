using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ExpeditionSlots {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

  }
}