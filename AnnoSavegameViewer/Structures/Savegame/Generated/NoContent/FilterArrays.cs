using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FilterArrays {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FilterArraysList> FilterArraysList { get; set; }

  }
}