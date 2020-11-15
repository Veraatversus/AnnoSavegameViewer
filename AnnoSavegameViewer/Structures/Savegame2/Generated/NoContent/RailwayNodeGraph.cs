namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RailwayNodeGraph {

    [BinaryContent(Name = "Nodes", NodeType = BinaryContentTypes.Node)]
    public Nodes Nodes { get; set; }

    [BinaryContent(Name = "HorizontalEdges", NodeType = BinaryContentTypes.Node)]
    public HorizontalEdges HorizontalEdges { get; set; }

    [BinaryContent(Name = "VerticalEdges", NodeType = BinaryContentTypes.Node)]
    public VerticalEdges VerticalEdges { get; set; }

  }
}