using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class AIConstructionManager {

[BinaryContent(Name = "PlannedSettlements", NodeType = BinaryContentTypes.Node)]
public PlannedSettlements PlannedSettlements { get; set; }

}
}
