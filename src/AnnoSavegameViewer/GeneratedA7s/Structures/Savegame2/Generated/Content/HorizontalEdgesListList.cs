namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class HorizontalEdgesListList {

    #region Public Properties

    [BinaryContent(Name = "SuppressRenderUpdates", NodeType = BinaryContentTypes.Attribute)]
    public object SuppressRenderUpdates { get; set; }

    [BinaryContent(Name = "Positions", NodeType = BinaryContentTypes.Node)]
    public Positions Positions { get; set; }

    [BinaryContent(Name = "OccupyTimes", NodeType = BinaryContentTypes.Node)]
    public OccupyTimes OccupyTimes { get; set; }

    #endregion Public Properties
  }
}