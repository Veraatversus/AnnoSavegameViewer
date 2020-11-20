namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class TargetShipWeights {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<TargetShipWeightsList> TargetShipWeightsList { get; set; }

  }
}