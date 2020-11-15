using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BalanceBeforeBudgets {

[BinaryContent(Name = "Income", NodeType = BinaryContentTypes.Attribute)]
public HexString Income { get; set; }

[BinaryContent(Name = "Expenses", NodeType = BinaryContentTypes.Attribute)]
public HexString Expenses { get; set; }

}
}
