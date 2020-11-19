namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaHappinessManager {

    [BinaryContent(Name = "HappinessData", NodeType = BinaryContentTypes.Node)]
    public HappinessData HappinessData { get; set; }

  }
}