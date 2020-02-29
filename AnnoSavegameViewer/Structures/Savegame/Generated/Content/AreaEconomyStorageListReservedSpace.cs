using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaEconomyStorageListReservedSpace {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<object> None { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaEconomyStorageListReservedSpaceList> AreaEconomyStorageListReservedSpaceList { get; set; }

    #endregion Public Properties
  }
}