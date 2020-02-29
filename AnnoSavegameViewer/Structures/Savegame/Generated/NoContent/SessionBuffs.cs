using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SessionBuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SessionBuffsList> SessionBuffsList { get; set; }

  }
}