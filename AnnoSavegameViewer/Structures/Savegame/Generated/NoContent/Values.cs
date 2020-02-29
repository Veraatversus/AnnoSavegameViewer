using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Values {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ValuesList> ValuesList { get; set; }

  }
}