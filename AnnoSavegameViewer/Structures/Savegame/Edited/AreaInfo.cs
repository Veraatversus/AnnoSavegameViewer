using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AreaInfo {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<short> Ids { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaInfoList> AreaInfoList { get; set; }

    #endregion Public Properties

    //public AreaInfoList GetAreaInfoById(int guid) => AreaInfoList[Array.IndexOf(Ids, guid)];
  }
}