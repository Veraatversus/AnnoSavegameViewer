using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class SelectionManager {

    [BinaryContent(Name = "SelectionGroupController", NodeType = BinaryContentTypes.Node)]
    public SelectionGroupController SelectionGroupController { get; set; }

  }
}