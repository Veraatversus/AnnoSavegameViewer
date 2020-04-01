using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OwnerType {

    [BinaryContent(Name = "OwnerType", NodeType = BinaryContentTypes.Attribute)]
    public object OwnerTypeItem { get; set; }

  }
}