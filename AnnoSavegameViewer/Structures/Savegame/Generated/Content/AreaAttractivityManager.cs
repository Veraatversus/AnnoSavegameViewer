using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaAttractivityManager {

    #region Public Properties

    [BinaryContent(Name = "CurCityStatus", NodeType = BinaryContentTypes.Attribute)]
    public object CurCityStatus { get; set; }

    [BinaryContent(Name = "MaxCityStatus", NodeType = BinaryContentTypes.Attribute)]
    public object MaxCityStatus { get; set; }

    [BinaryContent(Name = "BaseNatureAttractiveness", NodeType = BinaryContentTypes.Attribute)]
    public object BaseNatureAttractiveness { get; set; }

    [BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
    public TriggeredBanners TriggeredBanners { get; set; }

    #endregion Public Properties
  }
}