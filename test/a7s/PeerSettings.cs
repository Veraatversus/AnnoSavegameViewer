using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class PeerSettings {

[BinaryContent(Name = "RightClickMenuSettings", NodeType = BinaryContentTypes.Node)]
public RightClickMenuSettings RightClickMenuSettings { get; set; }

[BinaryContent(Name = "ConstructionBarSettings", NodeType = BinaryContentTypes.Node)]
public ConstructionBarSettings ConstructionBarSettings { get; set; }

[BinaryContent(Name = "MinimapFilter", NodeType = BinaryContentTypes.Node)]
public MinimapFilter MinimapFilter { get; set; }

[BinaryContent(Name = "FirstWelcomeMessageAvailable", NodeType = BinaryContentTypes.Node)]
public FirstWelcomeMessageAvailable FirstWelcomeMessageAvailable { get; set; }

[BinaryContent(Name = "ConstructionMenuMode", NodeType = BinaryContentTypes.Node)]
public ConstructionMenuMode ConstructionMenuMode { get; set; }

[BinaryContent(Name = "StraticMapBlacklist", NodeType = BinaryContentTypes.Node)]
public StraticMapBlacklist StraticMapBlacklist { get; set; }

[BinaryContent(Name = "MinimapZoom", NodeType = BinaryContentTypes.Attribute)]
public HexString MinimapZoom { get; set; }

}
}
