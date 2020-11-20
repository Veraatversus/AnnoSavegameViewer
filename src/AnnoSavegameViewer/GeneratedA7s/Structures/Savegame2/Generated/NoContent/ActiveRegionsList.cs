namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ActiveRegionsList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActiveRegionsListValue Value { get; set; }

  }
}