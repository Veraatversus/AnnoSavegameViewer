namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class UnlockData {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public Data Data { get; set; }

  }
}