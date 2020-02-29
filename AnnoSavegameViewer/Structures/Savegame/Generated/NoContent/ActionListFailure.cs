using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionListFailure {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ActionListFailureList ActionListFailureList { get; set; }

  }
}