using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class StreetMap {

[BinaryContent(Name = "StreetID", NodeType = BinaryContentTypes.Node)]
public StreetID StreetID { get; set; }

[BinaryContent(Name = "VarMapData", NodeType = BinaryContentTypes.Node)]
public VarMapData VarMapData { get; set; }

}
}
