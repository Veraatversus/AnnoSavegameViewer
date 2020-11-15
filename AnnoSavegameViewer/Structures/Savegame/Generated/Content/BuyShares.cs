namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class BuyShares {

    #region Public Properties

    [BinaryContent(Name = "m_NextCalculationTime", NodeType = BinaryContentTypes.Attribute)]
    public object M_NextCalculationTime { get; set; }

    [BinaryContent(Name = "m_IslandsToOvertake", NodeType = BinaryContentTypes.Attribute)]
    public object M_IslandsToOvertake { get; set; }

    [BinaryContent(Name = "m_IslandPriorities", NodeType = BinaryContentTypes.Node)]
    public M_IslandPriorities M_IslandPriorities { get; set; }

    #endregion Public Properties
  }
}