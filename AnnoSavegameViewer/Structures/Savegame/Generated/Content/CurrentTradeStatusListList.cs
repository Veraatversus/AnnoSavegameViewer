using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class CurrentTradeStatusListList {

    #region Public Properties

    [BinaryContent(Name = "Step", NodeType = BinaryContentTypes.Attribute)]
    public object Step { get; set; }

    [BinaryContent(Name = "CurrentAmount", NodeType = BinaryContentTypes.Attribute)]
    public object CurrentAmount { get; set; }

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public CurrentTradeStatusListListValue Value { get; set; }

    #endregion Public Properties
  }
}