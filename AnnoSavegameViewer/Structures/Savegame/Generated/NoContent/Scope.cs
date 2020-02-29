using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Scope {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ScopeValue Value { get; set; }

  }
}