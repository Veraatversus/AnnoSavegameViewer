using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MineProhibitZones {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MineProhibitZonesList> MineProhibitZonesList { get; set; }

  }
}