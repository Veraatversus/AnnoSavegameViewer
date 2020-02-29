using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionsList {

    #region Public Properties

    [BinaryContent(Name = "areaID", NodeType = BinaryContentTypes.Attribute)]
    public object AreaID { get; set; }

    [BinaryContent(Name = "amount", NodeType = BinaryContentTypes.Attribute)]
    public object Amount { get; set; }

    [BinaryContent(Name = "action", NodeType = BinaryContentTypes.Node)]
    public Action Action { get; set; }

    [BinaryContent(Name = "target", NodeType = BinaryContentTypes.Node)]
    public Target Target { get; set; }

    [BinaryContent(Name = "source", NodeType = BinaryContentTypes.Node)]
    public ActionsListSource Source { get; set; }

    [BinaryContent(Name = "cost", NodeType = BinaryContentTypes.Node)]
    public Cost Cost { get; set; }

    [BinaryContent(Name = "other", NodeType = BinaryContentTypes.Node)]
    public Other Other { get; set; }

    #endregion Public Properties
  }
}