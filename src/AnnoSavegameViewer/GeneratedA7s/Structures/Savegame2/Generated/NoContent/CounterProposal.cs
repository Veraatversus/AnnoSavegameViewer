namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class CounterProposal {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<CounterProposalList> CounterProposalList { get; set; }

  }
}