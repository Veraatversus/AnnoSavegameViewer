namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class FeedbackShips {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<FeedbackShipsList> FeedbackShipsList { get; set; }

  }
}