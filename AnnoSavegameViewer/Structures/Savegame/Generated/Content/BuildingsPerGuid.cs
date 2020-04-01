using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class BuildingsPerGuid {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

  }
}