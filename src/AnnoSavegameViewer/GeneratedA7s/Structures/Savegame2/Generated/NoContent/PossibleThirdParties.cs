namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PossibleThirdParties {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PossibleThirdPartiesList> PossibleThirdPartiesList { get; set; }

  }
}