namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class RandomIslandConfigValue {

    [BinaryContent(Name = "Type", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfigValueType Type { get; set; }

    [BinaryContent(Name = "Difficulty", NodeType = BinaryContentTypes.Node)]
    public Difficulty Difficulty { get; set; }

  }
}