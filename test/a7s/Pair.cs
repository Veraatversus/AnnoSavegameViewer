using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Pair {

[BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
public PairParticipantID ParticipantID { get; set; }

[BinaryContent(Name = "MetaEconomy", NodeType = BinaryContentTypes.Node)]
public MetaEconomy MetaEconomy { get; set; }

}
}
