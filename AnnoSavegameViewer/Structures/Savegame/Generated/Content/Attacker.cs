using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Attacker {

    #region Public Properties

    [BinaryContent(Name = "AutoAttackID", NodeType = BinaryContentTypes.Attribute)]
    public object AutoAttackID { get; set; }

    [BinaryContent(Name = "FirePerSide", NodeType = BinaryContentTypes.Attribute)]
    public object FirePerSide { get; set; }

    [BinaryContent(Name = "FutureBorrowedShots", NodeType = BinaryContentTypes.Attribute)]
    public object FutureBorrowedShots { get; set; }

    [BinaryContent(Name = "IsBlinded", NodeType = BinaryContentTypes.Attribute)]
    public object IsBlinded { get; set; }

    [BinaryContent(Name = "Turrets", NodeType = BinaryContentTypes.Node)]
    public Turrets Turrets { get; set; }

    [BinaryContent(Name = "ProjectileLaunchinformation", NodeType = BinaryContentTypes.Node)]
    public ProjectileLaunchinformation ProjectileLaunchinformation { get; set; }

    #endregion Public Properties
  }
}