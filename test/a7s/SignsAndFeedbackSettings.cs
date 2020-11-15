using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class SignsAndFeedbackSettings {

[BinaryContent(Name = "MinimapToken", NodeType = BinaryContentTypes.Attribute)]
public HexString MinimapToken { get; set; }

[BinaryContent(Name = "Infolayer", NodeType = BinaryContentTypes.Attribute)]
public HexString Infolayer { get; set; }

[BinaryContent(Name = "HideOnMinimap", NodeType = BinaryContentTypes.Attribute)]
public HexString HideOnMinimap { get; set; }

[BinaryContent(Name = "UseQuestOutlines", NodeType = BinaryContentTypes.Attribute)]
public HexString UseQuestOutlines { get; set; }

}
}
