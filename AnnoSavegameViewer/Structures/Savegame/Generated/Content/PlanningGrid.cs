using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class PlanningGrid {

    [BinaryContent(Name = "GridOrigin", NodeType = BinaryContentTypes.Attribute)]
    public object GridOrigin { get; set; }

    [BinaryContent(Name = "GridMax", NodeType = BinaryContentTypes.Attribute)]
    public object GridMax { get; set; }

    [BinaryContent(Name = "GridDimensions", NodeType = BinaryContentTypes.Attribute)]
    public object GridDimensions { get; set; }

    [BinaryContent(Name = "CellSize", NodeType = BinaryContentTypes.Attribute)]
    public object CellSize { get; set; }

    [BinaryContent(Name = "Grid", NodeType = BinaryContentTypes.Node)]
    public PlanningGridGrid Grid { get; set; }

  }
}