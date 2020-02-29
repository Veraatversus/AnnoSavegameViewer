using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ConstructionAIRegion {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ConstructionAIRegionValue Value { get; set; }

  }
}