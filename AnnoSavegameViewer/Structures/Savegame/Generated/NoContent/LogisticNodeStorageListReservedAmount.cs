namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class LogisticNodeStorageListReservedAmount {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<LogisticNodeStorageListReservedAmountList> LogisticNodeStorageListReservedAmountList { get; set; }

  }
}