using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class ResourceSatisfaction {

[BinaryContent(Name = "StableTradedTrade", NodeType = BinaryContentTypes.Node)]
public StableTradedTrade StableTradedTrade { get; set; }

[BinaryContent(Name = "StableUnstableTrade", NodeType = BinaryContentTypes.Node)]
public StableUnstableTrade StableUnstableTrade { get; set; }

[BinaryContent(Name = "ConnectedIslands", NodeType = BinaryContentTypes.Node)]
public ConnectedIslands ConnectedIslands { get; set; }

[BinaryContent(Name = "HappinessFactor", NodeType = BinaryContentTypes.Attribute)]
public HexString HappinessFactor { get; set; }

[BinaryContent(Name = "CrisisShareAmount", NodeType = BinaryContentTypes.Attribute)]
public HexString CrisisShareAmount { get; set; }

[BinaryContent(Name = "LastRiotTriggered", NodeType = BinaryContentTypes.Attribute)]
public HexString LastRiotTriggered { get; set; }

[BinaryContent(Name = "CurCrisisStart", NodeType = BinaryContentTypes.Attribute)]
public HexString CurCrisisStart { get; set; }

[BinaryContent(Name = "LastCrisisEnd", NodeType = BinaryContentTypes.Attribute)]
public HexString LastCrisisEnd { get; set; }

[BinaryContent(Name = "CrisisSeverity", NodeType = BinaryContentTypes.Attribute)]
public HexString CrisisSeverity { get; set; }

[BinaryContent(Name = "CrisisSeverityS", NodeType = BinaryContentTypes.Attribute)]
public HexString CrisisSeverityS { get; set; }

}
}
