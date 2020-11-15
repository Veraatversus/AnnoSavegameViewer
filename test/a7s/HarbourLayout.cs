using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class HarbourLayout {

[BinaryContent(Name = "HarborCount", NodeType = BinaryContentTypes.Attribute)]
public HexString HarborCount { get; set; }

[BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
public HexString ID { get; set; }

[BinaryContent(Name = "Harbor", NodeType = BinaryContentTypes.Node)]
public Harbor Harbor { get; set; }

[BinaryContent(Name = "harborBlockExtension", NodeType = BinaryContentTypes.Attribute)]
public HexString HarborBlockExtension { get; set; }

}
}
