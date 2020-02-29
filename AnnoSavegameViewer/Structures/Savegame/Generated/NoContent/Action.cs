using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Action {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionValue Value { get; set; }

  }
}