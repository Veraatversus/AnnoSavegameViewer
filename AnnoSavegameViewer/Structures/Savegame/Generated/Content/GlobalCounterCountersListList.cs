namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class GlobalCounterCountersListList {

    #region Public Properties

    [BinaryContent(Name = "Context", NodeType = BinaryContentTypes.Attribute)]
    public object Context { get; set; }

    [BinaryContent(Name = "Value", NodeType = BinaryContentTypes.Attribute)]
    public object Value { get; set; }

    [BinaryContent(Name = "PlayerCounter", NodeType = BinaryContentTypes.Node)]
    public GlobalCounterCountersListListPlayerCounter PlayerCounter { get; set; }

    #endregion Public Properties
  }
}