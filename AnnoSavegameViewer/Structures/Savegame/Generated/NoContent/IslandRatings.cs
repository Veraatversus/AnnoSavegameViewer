using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IslandRatings {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<IslandRatingsList> IslandRatingsList { get; set; }

  }
}