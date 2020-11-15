namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class AreaEconomyStorage {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<int> None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaEconomyStorageList> AreaEconomyStorageList { get; set; }

    #endregion Public Properties
  }
}