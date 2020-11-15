using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Mesh {

[BinaryContent(Name = "Flags", NodeType = BinaryContentTypes.Node)]
public Flags Flags { get; set; }

[BinaryContent(Name = "DyeColorDetail", NodeType = BinaryContentTypes.Attribute)]
public HexString DyeColorDetail { get; set; }

[BinaryContent(Name = "SequenceData", NodeType = BinaryContentTypes.Node)]
public SequenceData SequenceData { get; set; }

[BinaryContent(Name = "Orientation", NodeType = BinaryContentTypes.Attribute)]
public HexString Orientation { get; set; }

[BinaryContent(Name = "Damage", NodeType = BinaryContentTypes.Attribute)]
public HexString Damage { get; set; }

[BinaryContent(Name = "Scale", NodeType = BinaryContentTypes.Attribute)]
public HexString Scale { get; set; }

[BinaryContent(Name = "DyeColor", NodeType = BinaryContentTypes.Attribute)]
public HexString DyeColor { get; set; }

}
}
