using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MetaUnlockManager {

    [BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
    public LockState LockState { get; set; }

  }
}