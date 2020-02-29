using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionsListSource {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionsListSourceValue Value { get; set; }

  }
}