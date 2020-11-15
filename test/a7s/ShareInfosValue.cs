using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ShareInfosValue {

[BinaryContent(Name = "Bonus", NodeType = BinaryContentTypes.Attribute)]
public Int32 Bonus { get; set; }

[BinaryContent(Name = "TotalBonus", NodeType = BinaryContentTypes.Attribute)]
public Int32 TotalBonus { get; set; }

[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
public ShareInfosValuesNoneParticipantID ParticipantID { get; set; }

}
}
