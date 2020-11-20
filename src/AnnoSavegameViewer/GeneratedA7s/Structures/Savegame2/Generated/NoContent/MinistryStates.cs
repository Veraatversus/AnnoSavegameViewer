namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class MinistryStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<MinistryStatesList> MinistryStatesList { get; set; }

  }
}