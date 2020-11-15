using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RightClickMenuSettingsValue {

[BinaryContent(Name = "LockPosition", NodeType = BinaryContentTypes.Attribute)]
public HexString LockPosition { get; set; }

[BinaryContent(Name = "ButtonConfig", NodeType = BinaryContentTypes.Node)]
public ButtonConfig ButtonConfig { get; set; }

}
}
