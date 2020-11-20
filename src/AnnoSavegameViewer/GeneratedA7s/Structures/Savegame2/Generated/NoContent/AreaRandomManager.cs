namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AreaRandomManager {

    [BinaryContent(Name = "netsafeRandom", NodeType = BinaryContentTypes.Node)]
    public NetsafeRandom NetsafeRandom { get; set; }

  }
}