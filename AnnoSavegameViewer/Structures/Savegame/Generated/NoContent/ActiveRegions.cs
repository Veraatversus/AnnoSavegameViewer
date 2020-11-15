namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ActiveRegions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ActiveRegionsList ActiveRegionsList { get; set; }

  }
}