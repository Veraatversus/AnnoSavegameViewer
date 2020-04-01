using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Warehouse {

    [BinaryContent(Name = "StorageCapacityRegistered", NodeType = BinaryContentTypes.Attribute)]
    public object StorageCapacityRegistered { get; set; }

    [BinaryContent(Name = "LockedStorage", NodeType = BinaryContentTypes.Node)]
    public LockedStorage LockedStorage { get; set; }

  }
}