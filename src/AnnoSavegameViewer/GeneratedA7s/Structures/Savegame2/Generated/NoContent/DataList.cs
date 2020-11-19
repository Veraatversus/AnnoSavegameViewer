namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class DataList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DataListValue Value { get; set; }

    [BinaryContent(Name = "LockState", NodeType = BinaryContentTypes.Node)]
    public DataListLockState LockState { get; set; }

  }
}