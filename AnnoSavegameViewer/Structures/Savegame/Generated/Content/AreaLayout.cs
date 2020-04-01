using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaLayout {

    [BinaryContent(Name = "KontorBlocking", NodeType = BinaryContentTypes.Attribute)]
    public object KontorBlocking { get; set; }

    [BinaryContent(Name = "FineGrid", NodeType = BinaryContentTypes.Node)]
    public FineGrid FineGrid { get; set; }

    [BinaryContent(Name = "StaticGrid", NodeType = BinaryContentTypes.Node)]
    public StaticGrid StaticGrid { get; set; }

    [BinaryContent(Name = "PlanningGrid", NodeType = BinaryContentTypes.Node)]
    public PlanningGrid PlanningGrid { get; set; }

    [BinaryContent(Name = "MiscGrid", NodeType = BinaryContentTypes.Node)]
    public MiscGrid MiscGrid { get; set; }

    [BinaryContent(Name = "Districts", NodeType = BinaryContentTypes.Node)]
    public Districts Districts { get; set; }

    [BinaryContent(Name = "LayoutPlanner", NodeType = BinaryContentTypes.Node)]
    public LayoutPlanner LayoutPlanner { get; set; }

    [BinaryContent(Name = "RailwayHandler", NodeType = BinaryContentTypes.Node)]
    public RailwayHandler RailwayHandler { get; set; }

    [BinaryContent(Name = "ElectricityHandler", NodeType = BinaryContentTypes.Node)]
    public ElectricityHandler ElectricityHandler { get; set; }

    [BinaryContent(Name = "HeatHandler", NodeType = BinaryContentTypes.Node)]
    public HeatHandler HeatHandler { get; set; }

    [BinaryContent(Name = "KontorRotation", NodeType = BinaryContentTypes.Node)]
    public KontorRotation KontorRotation { get; set; }

    [BinaryContent(Name = "StreetPlanner", NodeType = BinaryContentTypes.Node)]
    public StreetPlanner StreetPlanner { get; set; }

  }
}