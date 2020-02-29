using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionByID {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ActionByIDList ActionByIDList { get; set; }

  }
}