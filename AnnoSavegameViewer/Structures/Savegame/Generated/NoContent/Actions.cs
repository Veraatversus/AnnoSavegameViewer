using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Actions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActionsList> ActionsList { get; set; }

  }
}