namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MetaUnlockManager {

    [BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
    public LockState LockState { get; set; }

  }
}