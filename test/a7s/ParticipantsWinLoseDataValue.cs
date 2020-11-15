using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ParticipantsWinLoseDataValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public ParticipantsWinLoseDataValuesNoneValue Value { get; set; }

[BinaryContent(Name = "WinLoseType", NodeType = BinaryContentTypes.Node)]
public WinLoseType WinLoseType { get; set; }

[BinaryContent(Name = "WinLoseState", NodeType = BinaryContentTypes.Node)]
public NoneWinLoseState WinLoseState { get; set; }

[BinaryContent(Name = "Winner", NodeType = BinaryContentTypes.Node)]
public Winner Winner { get; set; }

}
}
