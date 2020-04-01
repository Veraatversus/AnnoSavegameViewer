using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class MoralSubstracters {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public MoralSubstractersList MoralSubstractersList { get; set; }

  }
}