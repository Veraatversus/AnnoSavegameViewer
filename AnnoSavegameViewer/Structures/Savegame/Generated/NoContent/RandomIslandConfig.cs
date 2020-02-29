using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class RandomIslandConfig {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public RandomIslandConfigValue Value { get; set; }

  }
}