using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class NewspaperManager {

[BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
public IDManager IDManager { get; set; }

[BinaryContent(Name = "ParticipantData", NodeType = BinaryContentTypes.Node)]
public ParticipantData ParticipantData { get; set; }

}
}
