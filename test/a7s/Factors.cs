using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Factors {

[BinaryContent(Name = "base", NodeType = BinaryContentTypes.Attribute)]
public HexString Base { get; set; }

[BinaryContent(Name = "density", NodeType = BinaryContentTypes.Attribute)]
public HexString Density { get; set; }

[BinaryContent(Name = "productivity", NodeType = BinaryContentTypes.Attribute)]
public HexString Productivity { get; set; }

[BinaryContent(Name = "workingCondF", NodeType = BinaryContentTypes.Attribute)]
public HexString WorkingCondF { get; set; }

[BinaryContent(Name = "residenceHappiness", NodeType = BinaryContentTypes.Attribute)]
public HexString ResidenceHappiness { get; set; }

[BinaryContent(Name = "factoryHappiness", NodeType = BinaryContentTypes.Attribute)]
public HexString FactoryHappiness { get; set; }

}
}
