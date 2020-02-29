using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Filter {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FilterList> FilterList { get; set; }

  }
}