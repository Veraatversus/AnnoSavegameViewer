using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionEntered {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public SessionEnteredList SessionEnteredList { get; set; }

  }
}