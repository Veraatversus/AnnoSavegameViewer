using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DataListLockStateListValue {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DataListLockStateListValueValue Value { get; set; }

  }
}