using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlannedLoad {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PlannedLoadList> PlannedLoadList { get; set; }

  }
}