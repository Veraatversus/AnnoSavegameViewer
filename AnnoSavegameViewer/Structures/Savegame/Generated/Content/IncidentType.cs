using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentType {

    [BinaryContent(Name = "incidentType", NodeType = BinaryContentTypes.Attribute)]
    public object IncidentTypeItem { get; set; }

  }
}