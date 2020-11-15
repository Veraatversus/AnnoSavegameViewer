using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SessionDesc {

[BinaryContent(Name = "SessionGUID", NodeType = BinaryContentTypes.Attribute)]
public DescriptionInt SessionGUID { get; set; }

[BinaryContent(Name = "SessionID", NodeType = BinaryContentTypes.Attribute)]
public Int16 SessionID { get; set; }

[BinaryContent(Name = "SessionMap", NodeType = BinaryContentTypes.Attribute)]
public String SessionMap { get; set; }

[BinaryContent(Name = "MapGeneratorSettings", NodeType = BinaryContentTypes.Node)]
public MapGeneratorSettings MapGeneratorSettings { get; set; }

}
}
