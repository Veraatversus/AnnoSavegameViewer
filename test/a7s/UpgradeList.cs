using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class UpgradeList {

[BinaryContent(Name = "UpgradeGUIDs", NodeType = BinaryContentTypes.Attribute)]
public HexString UpgradeGUIDs { get; set; }

[BinaryContent(Name = "UpgradeSets", NodeType = BinaryContentTypes.Node)]
public UpgradeSets UpgradeSets { get; set; }

}
}
