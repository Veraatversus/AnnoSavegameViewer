using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ExpeditionsListState {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ExpeditionsListStateValue Value { get; set; }

  }
}