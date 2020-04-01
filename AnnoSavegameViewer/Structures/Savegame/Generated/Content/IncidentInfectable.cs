using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentInfectable {

    [BinaryContent(Name = "DensityBuffer", NodeType = BinaryContentTypes.Attribute)]
    public object DensityBuffer { get; set; }

    [BinaryContent(Name = "intensityInterval", NodeType = BinaryContentTypes.Attribute)]
    public object IntensityInterval { get; set; }

    [BinaryContent(Name = "perIncidentData", NodeType = BinaryContentTypes.Node)]
    public PerIncidentData PerIncidentData { get; set; }

    [BinaryContent(Name = "activeType", NodeType = BinaryContentTypes.Node)]
    public IncidentInfectableActiveType ActiveType { get; set; }

  }
}