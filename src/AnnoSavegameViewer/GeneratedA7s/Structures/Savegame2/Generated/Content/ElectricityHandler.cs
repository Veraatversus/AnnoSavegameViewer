namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ElectricityHandler {

    #region Public Properties

    [BinaryContent(Name = "LastRequesterTime", NodeType = BinaryContentTypes.Attribute)]
    public object LastRequesterTime { get; set; }

    [BinaryContent(Name = "PowerPlants", NodeType = BinaryContentTypes.Node)]
    public PowerPlants PowerPlants { get; set; }

    [BinaryContent(Name = "LastRequester", NodeType = BinaryContentTypes.Node)]
    public LastRequester LastRequester { get; set; }

    #endregion Public Properties
  }
}