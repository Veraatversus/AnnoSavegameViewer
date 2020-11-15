using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RegrowManager {

[BinaryContent(Name = "TreeMap", NodeType = BinaryContentTypes.Node)]
public TreeMap TreeMap { get; set; }

[BinaryContent(Name = "CreatedTreeMap", NodeType = BinaryContentTypes.Node)]
public CreatedTreeMap CreatedTreeMap { get; set; }

[BinaryContent(Name = "GrowingMap", NodeType = BinaryContentTypes.Node)]
public GrowingMap GrowingMap { get; set; }

}
}
