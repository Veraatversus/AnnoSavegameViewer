namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class HeatProvider {

    #region Public Properties

    [BinaryContent(Name = "TransporterRange", NodeType = BinaryContentTypes.Attribute)]
    public object TransporterRange { get; set; }

    [BinaryContent(Name = "ProductionState", NodeType = BinaryContentTypes.Node)]
    public HeatProviderProductionState ProductionState { get; set; }

    #endregion Public Properties
  }
}