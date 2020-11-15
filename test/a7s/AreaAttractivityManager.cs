using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaAttractivityManager {

[BinaryContent(Name = "BaseNatureAttractiveness", NodeType = BinaryContentTypes.Attribute)]
public HexString BaseNatureAttractiveness { get; set; }

[BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
public AreaAttractivityManagerTriggeredBanners TriggeredBanners { get; set; }

[BinaryContent(Name = "TriggeredBannersNew", NodeType = BinaryContentTypes.Node)]
public TriggeredBannersNew TriggeredBannersNew { get; set; }

[BinaryContent(Name = "MaxCityStatus", NodeType = BinaryContentTypes.Attribute)]
public HexString MaxCityStatus { get; set; }

[BinaryContent(Name = "CurCityStatus", NodeType = BinaryContentTypes.Attribute)]
public HexString CurCityStatus { get; set; }

}
}
