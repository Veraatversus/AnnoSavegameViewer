using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeTasks {

    [BinaryContent(Name = "OptimizeRequests", NodeType = BinaryContentTypes.Node)]
    public OptimizeRequests OptimizeRequests { get; set; }

  }
}