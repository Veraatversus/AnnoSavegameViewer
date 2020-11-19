namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class MineProhibitZones {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MineProhibitZonesList> MineProhibitZonesList { get; set; }

  }
}