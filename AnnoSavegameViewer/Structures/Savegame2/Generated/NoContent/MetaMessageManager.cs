namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class MetaMessageManager {

    [BinaryContent(Name = "NGT", NodeType = BinaryContentTypes.Node)]
    public NGT NGT { get; set; }

    [BinaryContent(Name = "ActionQueue", NodeType = BinaryContentTypes.Node)]
    public ActionQueue ActionQueue { get; set; }

  }
}