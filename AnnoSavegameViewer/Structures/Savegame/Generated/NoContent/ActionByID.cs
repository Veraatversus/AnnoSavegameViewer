using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionByID {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public ActionByIDList ActionByIDList { get; set; }

  }
}