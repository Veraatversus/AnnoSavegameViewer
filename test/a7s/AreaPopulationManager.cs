using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AreaPopulationManager {

[BinaryContent(Name = "CitySize", NodeType = BinaryContentTypes.Node)]
public CitySize CitySize { get; set; }

[BinaryContent(Name = "TriggeredBanners", NodeType = BinaryContentTypes.Node)]
public TriggeredBanners TriggeredBanners { get; set; }

}
}
