using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Type {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Attribute)]
    public object TypeItem { get; set; }

  }
}