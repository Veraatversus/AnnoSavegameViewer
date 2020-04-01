using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FeedbackShipsListState {

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Attribute)]
    public object State { get; set; }

  }
}