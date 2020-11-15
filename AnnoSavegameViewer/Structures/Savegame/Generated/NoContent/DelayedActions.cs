namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class DelayedActions {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DelayedActionsList> DelayedActionsList { get; set; }

  }
}