using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class HarborHandler {

    [BinaryContent(Name = "SecurityFactor", NodeType = BinaryContentTypes.Attribute)]
    public object SecurityFactor { get; set; }

  }
}