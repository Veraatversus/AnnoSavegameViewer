namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class StreetUpgradeAreas {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StreetUpgradeAreasList> StreetUpgradeAreasList { get; set; }

  }
}