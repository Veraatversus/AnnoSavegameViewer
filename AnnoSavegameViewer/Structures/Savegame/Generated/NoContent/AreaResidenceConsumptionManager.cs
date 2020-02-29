using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaResidenceConsumptionManager {

    [BinaryContent(Name = "ProductDistributionMap", NodeType = BinaryContentTypes.Node)]
    public ProductDistributionMap ProductDistributionMap { get; set; }

  }
}