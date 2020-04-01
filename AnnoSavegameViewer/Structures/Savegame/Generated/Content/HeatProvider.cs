using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HeatProvider {

    [BinaryContent(Name = "TransporterRange", NodeType = BinaryContentTypes.Attribute)]
    public object TransporterRange { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public HeatProviderProductionState ProductionState { get; set; }

  }
}