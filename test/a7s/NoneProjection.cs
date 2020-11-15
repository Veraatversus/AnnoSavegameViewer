using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneProjection {

[BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Attribute)]
public HexString Flags { get; set; }

[BinaryContent(Name = "FOV", NodeType = BinaryContentTypes.Attribute)]
public HexString FOV { get; set; }

[BinaryContent(Name = "NearClip", NodeType = BinaryContentTypes.Attribute)]
public HexString NearClip { get; set; }

[BinaryContent(Name = "FarClip", NodeType = BinaryContentTypes.Attribute)]
public HexString FarClip { get; set; }

[BinaryContent(Name = "AspectRatio", NodeType = BinaryContentTypes.Attribute)]
public HexString AspectRatio { get; set; }

}
}
