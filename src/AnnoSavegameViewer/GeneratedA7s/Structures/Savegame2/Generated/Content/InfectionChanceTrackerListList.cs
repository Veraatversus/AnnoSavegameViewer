namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class InfectionChanceTrackerListList {

    #region Public Properties

    [BinaryContent(Name = "Counter", NodeType = BinaryContentTypes.Attribute)]
    public object Counter { get; set; }

    [BinaryContent(Name = "AccumulatedInfectionChance", NodeType = BinaryContentTypes.Attribute)]
    public object AccumulatedInfectionChance { get; set; }

    #endregion Public Properties
  }
}