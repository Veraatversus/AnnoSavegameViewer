namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class IslandRatings {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<IslandRatingsList> IslandRatingsList { get; set; }

  }
}