namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Warehouse {

    [BinaryContent(Name = "StorageCapacityRegistered", NodeType = BinaryContentTypes.Attribute)]
    public object StorageCapacityRegistered { get; set; }

    [BinaryContent(Name = "LockedStorage", NodeType = BinaryContentTypes.Node)]
    public LockedStorage LockedStorage { get; set; }

  }
}