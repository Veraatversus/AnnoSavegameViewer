namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class CurrentTravel {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentTravelValue Value { get; set; }

  }
}