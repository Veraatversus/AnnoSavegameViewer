namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class OptimizeTaskTicks {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<OptimizeTaskTicksList> OptimizeTaskTicksList { get; set; }

  }
}