using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class FogOfWar {

[BinaryContent(Name = "IsInitialized", NodeType = BinaryContentTypes.Attribute)]
public HexString IsInitialized { get; set; }

[BinaryContent(Name = "DiscoverRadius", NodeType = BinaryContentTypes.Attribute)]
public HexString DiscoverRadius { get; set; }

[BinaryContent(Name = "FOWGrid", NodeType = BinaryContentTypes.Node)]
public FOWGrid FOWGrid { get; set; }

[BinaryContent(Name = "FOWArea", NodeType = BinaryContentTypes.Attribute)]
public HexString FOWArea { get; set; }

[BinaryContent(Name = "Objects", NodeType = BinaryContentTypes.Node)]
public FogOfWarObjects Objects { get; set; }

[BinaryContent(Name = "FogsOfWar", NodeType = BinaryContentTypes.Node)]
public FogsOfWar FogsOfWar { get; set; }

}
}
