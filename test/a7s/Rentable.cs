using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class Rentable {

[BinaryContent(Name = "Tenant", NodeType = BinaryContentTypes.Node)]
public Tenant Tenant { get; set; }

}
}
