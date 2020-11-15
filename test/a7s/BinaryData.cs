using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BinaryData {

[BinaryContent(Name = "SessionFileVersion", NodeType = BinaryContentTypes.Attribute)]
public HexString SessionFileVersion { get; set; }

[BinaryContent(Name = "GameSessionManager", NodeType = BinaryContentTypes.Node)]
public GameSessionManager GameSessionManager { get; set; }

}
}
