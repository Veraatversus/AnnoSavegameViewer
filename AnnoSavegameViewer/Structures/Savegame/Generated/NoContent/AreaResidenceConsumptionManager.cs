using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaResidenceConsumptionManager {

    [BinaryContent(Name = "ProductDistributionMap", NodeType = BinaryContentTypes.Node)]
    public ProductDistributionMap ProductDistributionMap { get; set; }

  }
}