namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Scope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ScopeValue Value { get; set; }

  }
}