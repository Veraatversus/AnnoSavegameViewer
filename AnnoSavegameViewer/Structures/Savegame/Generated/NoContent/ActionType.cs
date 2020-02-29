using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionType {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public ActionTypeValue Value { get; set; }

  }
}