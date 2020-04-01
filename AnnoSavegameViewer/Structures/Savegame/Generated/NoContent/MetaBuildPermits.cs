using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaBuildPermits {

    [BinaryContent(Name = "buildPermits", NodeType = BinaryContentTypes.Node)]
    public BuildPermits BuildPermits { get; set; }

  }
}