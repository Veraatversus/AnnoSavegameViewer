using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BudgetsValue {

[BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
public BudgetsValuesNoneValue Value { get; set; }

[BinaryContent(Name = "IncomeShare", NodeType = BinaryContentTypes.Attribute)]
public HexString IncomeShare { get; set; }

[BinaryContent(Name = "AvailableMoney", NodeType = BinaryContentTypes.Attribute)]
public HexString AvailableMoney { get; set; }

[BinaryContent(Name = "Costs", NodeType = BinaryContentTypes.Attribute)]
public HexString Costs { get; set; }

[BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
public HexString Income { get; set; }

[BinaryContent(Name = "Limit", NodeType = BinaryContentTypes.Attribute)]
public HexString Limit { get; set; }

}
}
