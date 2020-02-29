using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SelectionGroupController {

    [BinaryContent(Name = "StoredSelections", NodeType = BinaryContentTypes.Node)]
    public StoredSelections StoredSelections { get; set; }

  }
}