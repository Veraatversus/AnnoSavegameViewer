using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DecreeUnlockedStates {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DecreeUnlockedStatesList> DecreeUnlockedStatesList { get; set; }

  }
}