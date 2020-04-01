using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaOfActivity {

    [BinaryContent(Name = "ptCenter", NodeType = BinaryContentTypes.Attribute)]
    public object PtCenter { get; set; }

    [BinaryContent(Name = "Radius", NodeType = BinaryContentTypes.Attribute)]
    public object Radius { get; set; }

  }
}