using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class UpgradeList {

    #region Public Properties

    [BinaryContent(Name = "UpgradeGUIDs", NodeType = BinaryContentTypes.Attribute)]
    public AnnoUpgradeGUIDS UpgradeGUIDs { get; set; }

    [BinaryContent(Name = "ElectricityUpgrades", NodeType = BinaryContentTypes.Attribute)]
    public object ElectricityUpgrades { get; set; }

    [BinaryContent(Name = "HasElectricity", NodeType = BinaryContentTypes.Attribute)]
    public object HasElectricity { get; set; }

    [BinaryContent(Name = "UpgradeSets", NodeType = BinaryContentTypes.Node)]
    public UpgradeSets UpgradeSets { get; set; }

    #endregion Public Properties
  }
}