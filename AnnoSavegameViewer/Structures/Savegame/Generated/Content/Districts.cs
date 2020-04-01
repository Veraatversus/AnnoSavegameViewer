using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Districts {

    [BinaryContent(Name = "ReservedCellKontor", NodeType = BinaryContentTypes.Attribute)]
    public object ReservedCellKontor { get; set; }

    [BinaryContent(Name = "ReservedCellCityCore", NodeType = BinaryContentTypes.Attribute)]
    public object ReservedCellCityCore { get; set; }

    [BinaryContent(Name = "RecommendedCityRect", NodeType = BinaryContentTypes.Attribute)]
    public object RecommendedCityRect { get; set; }

    [BinaryContent(Name = "SlotPositions", NodeType = BinaryContentTypes.Node)]
    public SlotPositions SlotPositions { get; set; }

    [BinaryContent(Name = "VirtualSlots", NodeType = BinaryContentTypes.Node)]
    public VirtualSlots VirtualSlots { get; set; }

    [BinaryContent(Name = "Warehouses", NodeType = BinaryContentTypes.Node)]
    public Warehouses Warehouses { get; set; }

  }
}