using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UnlockData {

    [BinaryContent(Name = "Data", NodeType = BinaryContentTypes.Node)]
    public Data Data { get; set; }

  }
}