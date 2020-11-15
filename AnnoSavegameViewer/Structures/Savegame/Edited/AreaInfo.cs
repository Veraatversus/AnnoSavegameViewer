namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;
  using System.Linq;

  public class AreaInfo {

    #region Public Properties

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Attribute)]
    public List<short> Ids { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<AreaInfoList> AreaInfoList { get; set; }

    public Dictionary<short, AreaInfoList> KeyValuePairs {
      get => keyValuePairs ??= Ids.Zip(AreaInfoList).ToDictionary(x => x.First, x => x.Second);
      set => keyValuePairs = value;
    }

    #endregion Public Properties

    #region Private Fields

    private Dictionary<short, AreaInfoList> keyValuePairs;

    #endregion Private Fields

    //public AreaInfoList GetAreaInfoById(int guid) => AreaInfoList[Array.IndexOf(Ids, guid)];
  }
}