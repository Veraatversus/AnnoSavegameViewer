using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaHappinessManager {

    [BinaryContent(Name = "HappinessData", NodeType = BinaryContentTypes.Node)]
    public HappinessData HappinessData { get; set; }

  }
}