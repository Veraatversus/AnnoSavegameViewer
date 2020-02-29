using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class StoredSelections {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StoredSelectionsList> StoredSelectionsList { get; set; }

  }
}