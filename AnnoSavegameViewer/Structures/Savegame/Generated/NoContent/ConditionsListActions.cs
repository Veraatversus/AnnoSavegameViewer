using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConditionsListActions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsListActionsList> ConditionsListActionsList { get; set; }

  }
}