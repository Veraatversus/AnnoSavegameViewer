using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DelayedActions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DelayedActionsList> DelayedActionsList { get; set; }

  }
}