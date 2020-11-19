namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RandomIslandConfig {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfigValue Value { get; set; }

  }
}