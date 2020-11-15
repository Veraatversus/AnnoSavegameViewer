namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class SelectionGroupController {

    [BinaryContent(Name = "StoredSelections", NodeType = BinaryContentTypes.Node)]
    public StoredSelections StoredSelections { get; set; }

  }
}