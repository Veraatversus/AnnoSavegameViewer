using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaBuildPermits {

    [BinaryContent(Name = "buildPermits", NodeType = BinaryContentTypes.Node)]
    public BuildPermits BuildPermits { get; set; }

  }
}