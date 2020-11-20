namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class UpgradeList {

    #region Public Properties

    [BinaryContent(Name = "UpgradeGUIDs", NodeType = BinaryContentTypes.Attribute)]
    public DescriptionIntList UpgradeGUIDs { get; set; }

    [BinaryContent(Name = "ElectricityUpgrades", NodeType = BinaryContentTypes.Attribute)]
    public object ElectricityUpgrades { get; set; }

    [BinaryContent(Name = "HasElectricity", NodeType = BinaryContentTypes.Attribute)]
    public object HasElectricity { get; set; }

    [BinaryContent(Name = "UpgradeSets", NodeType = BinaryContentTypes.Node)]
    public UpgradeSets UpgradeSets { get; set; }

    #endregion Public Properties
  }
}