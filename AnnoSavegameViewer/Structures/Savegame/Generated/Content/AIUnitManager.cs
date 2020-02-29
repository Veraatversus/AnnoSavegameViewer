using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class AIUnitManager {

    #region Public Properties

    [BinaryContent(Name = "NextSquadID", NodeType = BinaryContentTypes.Attribute)]
    public object NextSquadID { get; set; }

    [BinaryContent(Name = "Squads", NodeType = BinaryContentTypes.Node)]
    public Squads Squads { get; set; }

    [BinaryContent(Name = "unitsToSquadIDs", NodeType = BinaryContentTypes.Node)]
    public UnitsToSquadIDs UnitsToSquadIDs { get; set; }

    #endregion Public Properties
  }
}