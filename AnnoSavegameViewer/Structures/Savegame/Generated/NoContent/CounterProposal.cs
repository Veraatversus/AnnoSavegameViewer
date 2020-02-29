using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CounterProposal {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CounterProposalList> CounterProposalList { get; set; }

  }
}