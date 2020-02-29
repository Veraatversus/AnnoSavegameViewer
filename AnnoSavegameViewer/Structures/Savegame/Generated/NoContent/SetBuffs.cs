using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SetBuffs {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<SetBuffsList> SetBuffsList { get; set; }

  }
}