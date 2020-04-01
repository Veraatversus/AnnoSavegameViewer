using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class LayoutPlanner {

    [BinaryContent(Name = "OpenLayout", NodeType = BinaryContentTypes.Node)]
    public OpenLayout OpenLayout { get; set; }

    [BinaryContent(Name = "ProductionLayout", NodeType = BinaryContentTypes.Node)]
    public ProductionLayout ProductionLayout { get; set; }

    [BinaryContent(Name = "CityLayout", NodeType = BinaryContentTypes.Node)]
    public CityLayout CityLayout { get; set; }

    [BinaryContent(Name = "CulturalLayout", NodeType = BinaryContentTypes.Node)]
    public CulturalLayout CulturalLayout { get; set; }

    [BinaryContent(Name = "MiscLayout", NodeType = BinaryContentTypes.Node)]
    public MiscLayout MiscLayout { get; set; }

    [BinaryContent(Name = "HarbourLayout", NodeType = BinaryContentTypes.Node)]
    public HarbourLayout HarbourLayout { get; set; }

  }
}