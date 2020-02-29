using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Conditions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsList> ConditionsList { get; set; }

  }
}