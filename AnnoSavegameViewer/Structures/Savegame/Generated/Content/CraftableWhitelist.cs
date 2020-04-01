using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CraftableWhitelist {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

  }
}