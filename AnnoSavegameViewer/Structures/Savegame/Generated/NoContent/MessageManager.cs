namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MessageManager {

    [BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
    public MessageManagerNGT NGT { get; set; }

    [BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
    public MessageManagerActionQueue ActionQueue { get; set; }

  }
}