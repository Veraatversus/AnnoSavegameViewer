using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ReputationOnStartList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ReputationOnStartListValue Value { get; set; }

  }
}