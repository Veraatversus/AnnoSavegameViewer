using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaHistoryListSnapshotsList {

    #region Public Properties

    [BinaryContent(Name = "CreationTime", NodeType = BinaryContentTypes.Attribute)]
    public object CreationTime { get; set; }

    [BinaryContent(Name = "AmountPerPopulation", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshotsListAmountPerPopulation AmountPerPopulation { get; set; }

    [BinaryContent(Name = "AmountPerProduct", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshotsListAmountPerProduct AmountPerProduct { get; set; }

    [BinaryContent(Name = "GenerationPerProduct", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshotsListGenerationPerProduct GenerationPerProduct { get; set; }

    [BinaryContent(Name = "ConsumptionPerProduct", NodeType = BinaryContentTypes.Node)]
    public AreaHistoryListSnapshotsListConsumptionPerProduct ConsumptionPerProduct { get; set; }

    #endregion Public Properties
  }
}