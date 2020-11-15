namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class EconomyStatisticManager {

    [BinaryContent(Name = "History", NodeType = BinaryContentTypes.Node)]
    public History History { get; set; }

  }
}