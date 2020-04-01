using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Subregion {

    [BinaryContent(Name = "subregion", NodeType = BinaryContentTypes.Attribute)]
    public object SubregionItem { get; set; }

  }
}