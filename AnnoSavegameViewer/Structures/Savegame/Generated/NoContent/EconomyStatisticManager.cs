using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class EconomyStatisticManager {

    [BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
    public History History { get; set; }

  }
}