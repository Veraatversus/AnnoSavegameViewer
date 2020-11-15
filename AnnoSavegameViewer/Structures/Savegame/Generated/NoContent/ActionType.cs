namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class ActionType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionTypeValue Value { get; set; }

  }
}