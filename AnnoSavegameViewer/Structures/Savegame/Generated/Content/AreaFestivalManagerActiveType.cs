using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaFestivalManagerActiveType {

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Attribute)]
    public object ActiveType { get; set; }

  }
}