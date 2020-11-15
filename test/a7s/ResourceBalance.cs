using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ResourceBalance {

[BinaryContent(Name = "OwnedGoods", NodeType = BinaryContentTypes.Node)]
public OwnedGoods OwnedGoods { get; set; }

[BinaryContent(Name = "EstimatedConstructionGoods", NodeType = BinaryContentTypes.Node)]
public EstimatedConstructionGoods EstimatedConstructionGoods { get; set; }

[BinaryContent(Name = "ConstructionMaterialUnlocks", NodeType = BinaryContentTypes.Node)]
public ConstructionMaterialUnlocks ConstructionMaterialUnlocks { get; set; }

[BinaryContent(Name = "AreaNeedUnlocks", NodeType = BinaryContentTypes.Node)]
public AreaNeedUnlocks AreaNeedUnlocks { get; set; }

[BinaryContent(Name = "Balance", NodeType = BinaryContentTypes.Node)]
public ResourceBalanceBalance Balance { get; set; }

[BinaryContent(Name = "Storage", NodeType = BinaryContentTypes.Attribute)]
public HexString Storage { get; set; }

[BinaryContent(Name = "SpecialStorage", NodeType = BinaryContentTypes.Node)]
public SpecialStorage SpecialStorage { get; set; }

}
}
