using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FeedbackShipsList {

    [BinaryContent(Name = "TargetArea", NodeType = BinaryContentTypes.Attribute)]
    public object TargetArea { get; set; }

    [BinaryContent(Name = "ContinueTimestamp", NodeType = BinaryContentTypes.Attribute)]
    public object ContinueTimestamp { get; set; }

    [BinaryContent(Name = "Reverse", NodeType = BinaryContentTypes.Attribute)]
    public object Reverse { get; set; }

    [BinaryContent(Name = "Target", NodeType = BinaryContentTypes.Node)]
    public FeedbackShipsListTarget Target { get; set; }

    [BinaryContent(Name = "Ship", NodeType = BinaryContentTypes.Node)]
    public Ship Ship { get; set; }

    [BinaryContent(Name = "State", NodeType = BinaryContentTypes.Node)]
    public FeedbackShipsListState State { get; set; }

  }
}