using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DecreeStatesList {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DecreeStatesListList> DecreeStatesListList { get; set; }

  }
}