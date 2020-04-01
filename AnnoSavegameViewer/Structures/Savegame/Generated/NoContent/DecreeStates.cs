using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DecreeStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DecreeStatesList> DecreeStatesList { get; set; }

  }
}