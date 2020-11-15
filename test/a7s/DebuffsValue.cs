using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class DebuffsValue {

[BinaryContent(Name = "DebuffEnd", NodeType = BinaryContentTypes.Attribute)]
public HexString DebuffEnd { get; set; }

[BinaryContent(Name = "DiceDebuff", NodeType = BinaryContentTypes.Attribute)]
public HexString DiceDebuff { get; set; }

}
}
