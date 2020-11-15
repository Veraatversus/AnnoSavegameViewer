namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DivingBellObjectInfoListList {

    #region Public Properties

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public object GUID { get; set; }

    [BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
    public object CargoGUID { get; set; }

    [BinaryContent(Name = "IsTreasure", NodeType = BinaryContentTypes.Attribute)]
    public object IsTreasure { get; set; }

    #endregion Public Properties
  }
}