using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CounterProposalListCounterProposal {

    [BinaryContent(Name = "From", NodeType = BinaryContentTypes.Node)]
    public From From { get; set; }

    [BinaryContent(Name = "To", NodeType = BinaryContentTypes.Node)]
    public To To { get; set; }

    [BinaryContent(Name = "Actions", NodeType = BinaryContentTypes.Node)]
    public Actions Actions { get; set; }

    [BinaryContent(Name = "m_TargetPeer", NodeType = BinaryContentTypes.Node)]
    public M_TargetPeer M_TargetPeer { get; set; }

  }
}