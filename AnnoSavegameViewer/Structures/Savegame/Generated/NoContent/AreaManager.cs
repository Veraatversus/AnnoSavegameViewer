namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaManager {

    [BinaryContent(Name = "AreaRandomManager", NodeType = BinaryContentTypes.Node)]
    public AreaRandomManager AreaRandomManager { get; set; }

    [BinaryContent(Name = "AreaPopulationManager", NodeType = BinaryContentTypes.Node)]
    public AreaPopulationManager AreaPopulationManager { get; set; }

    [BinaryContent(Name = "AreaIrrigationManager", NodeType = BinaryContentTypes.Node)]
    public AreaIrrigationManager AreaIrrigationManager { get; set; }

    [BinaryContent(Name = "AreaRailwayManager", NodeType = BinaryContentTypes.Node)]
    public AreaRailwayManager AreaRailwayManager { get; set; }

    [BinaryContent(Name = "AreaObjectManager", NodeType = BinaryContentTypes.Node)]
    public AreaObjectManager AreaObjectManager { get; set; }

    [BinaryContent(Name = "AreaResidenceConsumptionManager", NodeType = BinaryContentTypes.Node)]
    public AreaResidenceConsumptionManager AreaResidenceConsumptionManager { get; set; }

    [BinaryContent(Name = "AreaTransporterManager", NodeType = BinaryContentTypes.Node)]
    public AreaTransporterManager AreaTransporterManager { get; set; }

    [BinaryContent(Name = "AreaElectricity", NodeType = BinaryContentTypes.Node)]
    public AreaElectricity AreaElectricity { get; set; }

    [BinaryContent(Name = "AreaAttractivityManager", NodeType = BinaryContentTypes.Node)]
    public AreaAttractivityManager AreaAttractivityManager { get; set; }

    [BinaryContent(Name = "AreaItemManager", NodeType = BinaryContentTypes.Node)]
    public AreaItemManager AreaItemManager { get; set; }

    [BinaryContent(Name = "AreaIncidentManager", NodeType = BinaryContentTypes.Node)]
    public List<AreaIncidentManager> AreaIncidentManager { get; set; }

    [BinaryContent(Name = "AreaHappinessManager", NodeType = BinaryContentTypes.Node)]
    public AreaHappinessManager AreaHappinessManager { get; set; }

    [BinaryContent(Name = "AreaFestivalManager", NodeType = BinaryContentTypes.Node)]
    public AreaFestivalManager AreaFestivalManager { get; set; }

    [BinaryContent(Name = "AreaHarbourPropManager", NodeType = BinaryContentTypes.Node)]
    public AreaHarbourPropManager AreaHarbourPropManager { get; set; }

    [BinaryContent(Name = "AreaSaturationTrackerManager", NodeType = BinaryContentTypes.Node)]
    public AreaSaturationTrackerManager AreaSaturationTrackerManager { get; set; }

  }
}