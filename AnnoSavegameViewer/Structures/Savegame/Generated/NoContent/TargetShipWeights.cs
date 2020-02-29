using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class TargetShipWeights {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TargetShipWeightsList> TargetShipWeightsList { get; set; }

  }
}