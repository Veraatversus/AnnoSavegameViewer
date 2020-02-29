using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentTypeData {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<IncidentTypeDataList> IncidentTypeDataList { get; set; }

  }
}