namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class EconomyManager {

    #region Public Properties

    [BinaryContent(Name = "MetaStorageCount", NodeType = BinaryContentTypes.Attribute)]
    public object MetaStorageCount { get; set; }

    [BinaryContent(Name = "Pair", NodeType = BinaryContentTypes.Node)]
    public List<Pair> Pair { get; set; }

    #endregion Public Properties
  }
}