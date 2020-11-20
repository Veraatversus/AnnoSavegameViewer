namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaEconomyStorageList {

    #region Public Properties

    [BinaryContent(Name = "ProductGUID", NodeType = BinaryContentTypes.Attribute)]
    public int ProductGUID { get; set; }

    [BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
    public int CurrentAmount { get; set; }

    [BinaryContent(Name = "MaxAmount", NodeType = BinaryContentTypes.Attribute)]
    public int MaxAmount { get; set; }

    [BinaryContent(Name = "ReservedAmount", NodeType = BinaryContentTypes.Node)]
    public AreaEconomyStorageListReservedAmount ReservedAmount { get; set; }

    [BinaryContent(Name = "ReservedSpace", NodeType = BinaryContentTypes.Node)]
    public AreaEconomyStorageListReservedSpace ReservedSpace { get; set; }

    #endregion Public Properties
  }
}