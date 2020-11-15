using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class LoadingPier {

[BinaryContent(Name = "LoadingHarbourID", NodeType = BinaryContentTypes.Attribute)]
public HexString LoadingHarbourID { get; set; }

[BinaryContent(Name = "CurrentTradePartnerArray", NodeType = BinaryContentTypes.Node)]
public CurrentTradePartnerArray CurrentTradePartnerArray { get; set; }

}
}
