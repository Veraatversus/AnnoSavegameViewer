namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class ConditionsListActions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<ConditionsListActionsList> ConditionsListActionsList { get; set; }

  }
}