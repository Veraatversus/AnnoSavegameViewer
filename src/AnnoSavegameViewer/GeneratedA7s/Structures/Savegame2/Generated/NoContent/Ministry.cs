namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Ministry {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public MinistryValue Value { get; set; }

  }
}