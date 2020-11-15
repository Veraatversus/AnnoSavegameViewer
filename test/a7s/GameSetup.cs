using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GameSetup {

[BinaryContent(Name = "Peers", NodeType = BinaryContentTypes.Node)]
public GameSetupPeers Peers { get; set; }

[BinaryContent(Name = "GameSeed", NodeType = BinaryContentTypes.Attribute)]
public HexString GameSeed { get; set; }

[BinaryContent(Name = "Customizable", NodeType = BinaryContentTypes.Attribute)]
public HexString Customizable { get; set; }

[BinaryContent(Name = "Maps", NodeType = BinaryContentTypes.Node)]
public GameSetupMaps Maps { get; set; }

[BinaryContent(Name = "GameSetupDifficulty", NodeType = BinaryContentTypes.Node)]
public GameSetupGameSetupDifficulty GameSetupDifficulty { get; set; }

[BinaryContent(Name = "SavegameFolderW", NodeType = BinaryContentTypes.Attribute)]
public HexString SavegameFolderW { get; set; }

[BinaryContent(Name = "ActiveDLCs", NodeType = BinaryContentTypes.Node)]
public GameSetupActiveDLCs ActiveDLCs { get; set; }

[BinaryContent(Name = "ActiveHappyDayEvents", NodeType = BinaryContentTypes.Attribute)]
public HexString ActiveHappyDayEvents { get; set; }

}
}
