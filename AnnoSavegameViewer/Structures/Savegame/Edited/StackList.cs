using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StackList {

    #region Public Properties

    [BinaryContent(Name = "ID", NodeType = BinaryContentTypes.Attribute)]
    public long ID { get; set; }

    [BinaryContent(Name = "GUID", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionInt GUID { get; set; }

    #endregion Public Properties
  }
}