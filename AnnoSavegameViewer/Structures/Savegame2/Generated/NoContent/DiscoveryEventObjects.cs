namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DiscoveryEventObjects {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiscoveryEventObjectsList> DiscoveryEventObjectsList { get; set; }

  }
}