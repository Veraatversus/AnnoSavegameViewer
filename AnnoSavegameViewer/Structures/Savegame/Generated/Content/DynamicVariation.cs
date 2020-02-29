using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DynamicVariation {

    [BinaryContent(Name = "ConfigFilename", NodeType = BinaryContentTypes.Attribute)]
    public object ConfigFilename { get; set; }

  }
}