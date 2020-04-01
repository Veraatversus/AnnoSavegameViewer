using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Pair {

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public PairParticipantID ParticipantID { get; set; }

    [BinaryContent(Name = "MetaEconomy", NodeType = BinaryContentTypes.Node)]
    public MetaEconomy MetaEconomy { get; set; }

  }
}