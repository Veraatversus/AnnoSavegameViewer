using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CargoGUIDListList {

    #region Public Properties

    [BinaryContent(Name = "CargoGUID", NodeType = BinaryContentTypes.Attribute)]
    public object CargoGUID { get; set; }

    [BinaryContent(Name = "CargoAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CargoAmount { get; set; }

    #endregion Public Properties
  }
}