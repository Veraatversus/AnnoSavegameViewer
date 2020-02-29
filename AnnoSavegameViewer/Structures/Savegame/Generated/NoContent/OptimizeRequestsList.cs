using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class OptimizeRequestsList {

    [BinaryContent(Name = "OptimizeTaskTicks", NodeType = BinaryContentTypes.Node)]
    public OptimizeTaskTicks OptimizeTaskTicks { get; set; }

  }
}