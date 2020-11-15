namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaAttractivityManager {

    [BinaryContent(Name = "BaseNatureAttractiveness", NodeType = BinaryContentTypes.Attribute)]
    public object BaseNatureAttractiveness { get; set; }

    [BinaryContent(Name = "MaxCityStatus", NodeType = BinaryContentTypes.Attribute)]
    public object MaxCityStatus { get; set; }

    [BinaryContent(Name = "CurCityStatus", NodeType = BinaryContentTypes.Attribute)]
    public object CurCityStatus { get; set; }

    [BinaryContent(Name = "MaxParagonShown", NodeType = BinaryContentTypes.Attribute)]
    public object MaxParagonShown { get; set; }

    [BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
    public AreaAttractivityManagerTriggeredBanners TriggeredBanners { get; set; }

    [BinaryContent(Name = "TriggeredBannersNew", NodeType = BinaryContentTypes.Node)]
    public TriggeredBannersNew TriggeredBannersNew { get; set; }
  }
}