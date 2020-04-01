using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ElectricityHandler {

    [BinaryContent(Name = "LastRequesterTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastRequesterTime { get; set; }

    [BinaryContent(Name = "PowerPlants", NodeType = BinaryContentTypes.Node)]
    public PowerPlants PowerPlants { get; set; }

    [BinaryContent(Name = "LastRequester", NodeType = BinaryContentTypes.Node)]
    public LastRequester LastRequester { get; set; }

  }
}