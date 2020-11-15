using AnnoSavegameViewer.Serialization.Core;
using AnnoSavegameViewer.Structures.DataTypes;
using System;

namespace AnnoSavegameViewer.Structures.a7s.Generated {

public partial class RailwayNodeGraph {

[BinaryContent(Name = "Nodes", NodeType = BinaryContentTypes.Node)]
public Nodes Nodes { get; set; }

[BinaryContent(Name = "HorizontalEdges", NodeType = BinaryContentTypes.Node)]
public HorizontalEdges HorizontalEdges { get; set; }

[BinaryContent(Name = "VerticalEdges", NodeType = BinaryContentTypes.Node)]
public VerticalEdges VerticalEdges { get; set; }

}
}
