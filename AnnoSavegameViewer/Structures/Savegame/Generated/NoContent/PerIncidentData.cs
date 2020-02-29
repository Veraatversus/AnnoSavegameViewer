using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PerIncidentData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PerIncidentDataList> PerIncidentDataList { get; set; }

  }
}