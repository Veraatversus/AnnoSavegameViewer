using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CounterProposalList {

    [BinaryContent(Name = "Id", NodeType = BinaryContentTypes.Attribute)]
    public object Id { get; set; }

    [BinaryContent(Name = "MinMoney", NodeType = BinaryContentTypes.Attribute)]
    public object MinMoney { get; set; }

    [BinaryContent(Name = "MaxMoney", NodeType = BinaryContentTypes.Attribute)]
    public object MaxMoney { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CounterProposalListValue Value { get; set; }

    [BinaryContent(Name = "CounterProposal", NodeType = BinaryContentTypes.Node)]
    public CounterProposalListCounterProposal CounterProposal { get; set; }

  }
}