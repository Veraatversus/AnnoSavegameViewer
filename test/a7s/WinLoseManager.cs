using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class WinLoseManager {

[BinaryContent(Name = "LoseConditionsCount", NodeType = BinaryContentTypes.Attribute)]
public HexString LoseConditionsCount { get; set; }

[BinaryContent(Name = "ParticipantsWinLoseData", NodeType = BinaryContentTypes.Node)]
public ParticipantsWinLoseData ParticipantsWinLoseData { get; set; }

[BinaryContent(Name = "WinLoseCondition", NodeType = BinaryContentTypes.Node)]
public WinLoseCondition WinLoseCondition { get; set; }

}
}
