using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FeedbackShipsListState {

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
    public object State { get; set; }

  }
}