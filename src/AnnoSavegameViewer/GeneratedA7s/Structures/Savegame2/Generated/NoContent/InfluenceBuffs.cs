namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class InfluenceBuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<InfluenceBuffsList> InfluenceBuffsList { get; set; }

  }
}