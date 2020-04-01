using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Nameable {

    [BinaryContent(Name = "VehicleTextGuid", NodeType = BinaryContentTypes.Attribute)]
    public object VehicleTextGuid { get; set; }

    [BinaryContent(Name = "VehicleTextIterator", NodeType = BinaryContentTypes.Attribute)]
    public object VehicleTextIterator { get; set; }

    [BinaryContent(Name = "VehicleName", NodeType = BinaryContentTypes.Attribute)]
    public object VehicleName { get; set; }

  }
}