using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class CounterProposalValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public CounterProposalValuesNoneValue Value { get; set; }

[BinaryContent(Name = "Id", NodeType = BinaryContentTypes.Attribute)]
public HexString Id { get; set; }

[BinaryContent(Name = "MinMoney", NodeType = BinaryContentTypes.Attribute)]
public HexString MinMoney { get; set; }

[BinaryContent(Name = "MaxMoney", NodeType = BinaryContentTypes.Attribute)]
public HexString MaxMoney { get; set; }

[BinaryContent(Name = "CounterProposal", NodeType = BinaryContentTypes.Node)]
public NoneCounterProposal CounterProposal { get; set; }

}
}
