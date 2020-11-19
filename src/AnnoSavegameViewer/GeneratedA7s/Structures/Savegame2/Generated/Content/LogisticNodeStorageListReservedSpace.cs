namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class LogisticNodeStorageListReservedSpace {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LogisticNodeStorageListReservedSpaceList> LogisticNodeStorageListReservedSpaceList { get; set; }

    #endregion Public Properties
  }
}