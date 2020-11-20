namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class Conditions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsList> ConditionsList { get; set; }

  }
}