namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class HappinessDataOwner {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public HappinessDataOwnerValue Value { get; set; }

  }
}