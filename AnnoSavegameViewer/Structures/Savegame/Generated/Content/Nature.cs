namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Nature {

    [BinaryContent(Name = "objects", NodeType = BinaryContentTypes.Node)]
    public NatureObjects Objects { get; set; }

  }
}