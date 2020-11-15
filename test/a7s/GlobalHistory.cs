using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class GlobalHistory {

[BinaryContent(Name = "Snapshots", NodeType = BinaryContentTypes.Node)]
public Snapshots Snapshots { get; set; }

}
}
