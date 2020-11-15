using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class BuildingModule {

[BinaryContent(Name = "ParentFactoryID", NodeType = BinaryContentTypes.Attribute)]
public HexString ParentFactoryID { get; set; }

[BinaryContent(Name = "CultureSlotIndex", NodeType = BinaryContentTypes.Attribute)]
public HexString CultureSlotIndex { get; set; }

}
}
