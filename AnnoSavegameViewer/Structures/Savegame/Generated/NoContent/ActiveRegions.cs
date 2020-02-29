using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActiveRegions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ActiveRegionsList ActiveRegionsList { get; set; }

  }
}