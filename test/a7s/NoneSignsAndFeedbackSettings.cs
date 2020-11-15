using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NoneSignsAndFeedbackSettings {

[BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
public HexString MinimapToken { get; set; }

[BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
public HexString Infolayer { get; set; }

}
}
