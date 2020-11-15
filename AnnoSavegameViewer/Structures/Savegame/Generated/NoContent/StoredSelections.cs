namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;
  using System.Collections.Generic;

  public class StoredSelections {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<StoredSelectionsList> StoredSelectionsList { get; set; }

  }
}