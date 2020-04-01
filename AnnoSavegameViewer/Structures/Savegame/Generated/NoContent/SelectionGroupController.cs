using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SelectionGroupController {

    [BinaryContent(Name = "StoredSelections", NodeType = BinaryContentTypes.Node)]
    public StoredSelections StoredSelections { get; set; }

  }
}