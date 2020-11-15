namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class PropagandaChances {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<PropagandaChancesList> PropagandaChancesList { get; set; }

  }
}