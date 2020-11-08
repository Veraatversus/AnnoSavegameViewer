using AnnoSavegameViewer.Serialization.Core;
using System.Diagnostics;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  [DebuggerDisplay("Insel {CityName}")]
  public class AreaInfoList {

    #region Public Properties

    [BinaryContent(Name = "CityNameGuid", NodeType = BinaryContentTypes.Attribute)]
    public int CityNameGuid { get; set; }

    [BinaryContent(Name = "CityNameIterator", NodeType = BinaryContentTypes.Attribute)]
    public int CityNameIterator { get; set; }

    [BinaryContent(Name = "CityName", Encoding = "utf-16", NodeType = BinaryContentTypes.Attribute)]
    public string CityName { get; set; }

    public string CityNameOrGuid => CityName ?? CityNameGuid.ToString();

    [BinaryContent(Name = "WasEverOwned", NodeType = BinaryContentTypes.Attribute)]
    public bool WasEverOwned { get; set; }

    [BinaryContent(Name = "Fertility", NodeType = BinaryContentTypes.Node)]
    public Fertility Fertility { get; set; }

    [BinaryContent(Name = "Owner", NodeType = BinaryContentTypes.Node)]
    public AreaInfoListOwner Owner { get; set; }

    [BinaryContent(Name = "ShareInfos", NodeType = BinaryContentTypes.Node)]
    public ShareInfos ShareInfos { get; set; }

    [BinaryContent(Name = "ShareCoolDowns", NodeType = BinaryContentTypes.Node)]
    public ShareCoolDowns ShareCoolDowns { get; set; }

    [BinaryContent(Name = "AreaEconomy", NodeType = BinaryContentTypes.Node)]
    public AreaEconomy AreaEconomy { get; set; }

    [BinaryContent(Name = "PassiveTrade", NodeType = BinaryContentTypes.Node)]
    public PassiveTrade PassiveTrade { get; set; }

    [BinaryContent(Name = "MilTakeOverData", NodeType = BinaryContentTypes.Node)]
    public MilTakeOverData MilTakeOverData { get; set; }

    #endregion Public Properties
  }
}