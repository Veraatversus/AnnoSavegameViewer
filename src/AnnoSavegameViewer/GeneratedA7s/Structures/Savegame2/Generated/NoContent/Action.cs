namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class Action {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionValue Value { get; set; }

  }
}