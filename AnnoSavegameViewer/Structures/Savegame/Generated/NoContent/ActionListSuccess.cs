using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionListSuccess {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ActionListSuccessList> ActionListSuccessList { get; set; }

  }
}